using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creator
{
    public partial class Form1 : Form
    {
        public static string exportSystem;
        public string dateCheck;
        public string itemList = Environment.CurrentDirectory + "\\Common Data\\ItemList.json";


        
        public Form1()
        {
            InitializeComponent();
        }
        /* private IEnumerable<string> GetItems(ListBox npcLoveData)
          {
              foreach (object entry in npcLoveData.Items)
                  yield return entry.ToString();
          }*/
        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
        }
        class ItemDescription
        {
            public ItemDescription(string name, string id)
            {
                Name = name;
                Id = id;
            }
            public string Name;
            public string Id;
            public override string ToString()
            {
                return Name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            systemTip.SetToolTip(npcSystemName, "This is how the game Identifies your NPC!  Do NOT Change IT!!");
            ageTip.SetToolTip(npcAge, "Selects the age of the NPC.  Children should NOT be dateable!");
            mannersTip.SetToolTip(npcManners, "Works with generic dialogue.  No other impact known.");
            socialTip.SetToolTip(npcSocial, "Works with generic dialogue.  No other impact known.");
            outlookTip.SetToolTip(npcOutlook, "Works with generic dialogue.  No other impact known.");
            genderTip.SetToolTip(npcGender, "Stardew Valley has either Male or Female roles, choose what suits the NPC best.");
            dateTip.SetToolTip(npcDateable, "Do you wish this NPC to be Married?");
            loveIntTip.SetToolTip(npcLoveInterest, "Place another NPC's name here.. if not needed, put `null`");
            homeTip.SetToolTip(npcRegion, "This affects hearts from certain Festivals.");
            bSeasonTip.SetToolTip(npcBseason, "Which season was the NPC born?");
            bDayTip.SetToolTip(npcBday, "Select day of birth.  1 - 28");
            relationTip.SetToolTip(npcRelation, "Family and Friends can go here: <NPC Name> '<relation>'.  Leave Blank if no relationships to others.");
            startTip.SetToolTip(npcStart, "Map Location and X Y Tile coordinates.  Example: BusStop 22 5");
            displayTip.SetToolTip(npcDisplayname, "This can be changed as needed.  This is the displayed name shown in menus and dialogue boxes.");
            string populateItem = File.ReadAllText(itemList);
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemsByID.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }

        }


        private void Label1_Click_1(object sender, EventArgs e)
        {


        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void ModResource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.modResource.LinkVisited = true;

            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1CpDrw23peQiq-C7F2FjYOMePaYe0Rc9BwQsj3h6sjyo/edit#gid=239695361");
            
        }

        private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.modResource.LinkVisited = true;

            System.Diagnostics.Process.Start("https://discord.gg/stardewvalley");
        }

        private void GenerateNPC_Click(object sender, EventArgs e)
        {
            dateCheck = $"{npcDateable.SelectedItem}";
            if (Directory.Exists($"Export/[CP]{npcSystemName.Text}"))
            {

                if (string.IsNullOrWhiteSpace(npcSystemName.Text))
                {
                    MessageBox.Show("Please enter a System Name!!", "WHOOPSIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    if (!File.Exists($"Export/[CP]{npcSystemName.Text}/manifest.json"))
                    {
                        MessageBox.Show("There is no Manifest for your NPC.  We will open the Manifest Creator for you.", "Manifest Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        manifestCreator xrRem = new manifestCreator();
                        Form1.exportSystem = this.npcSystemName.Text;
                        xrRem.ShowDialog();
                    }
                    PatchVariable patchDisposition = new PatchVariable
                    {
                        LogName = "NPC Manifestation",
                        Action = "EditData",
                        Target = "Data/NPCDispositions",
                        Entries = new Dictionary<string, string>
                        {
                            [$"{npcSystemName.Text}"] = $"{npcAge.SelectedItem}/{npcManners.SelectedItem}/{npcSocial.SelectedItem}/{npcOutlook.SelectedItem}/{npcGender.SelectedItem}/{npcDateable.SelectedItem}/{npcLoveInterest.Text}/{npcRegion.SelectedItem}/{npcBseason.SelectedItem} {npcBday.Value}/{npcRelation.Text}/{npcStart.Text}/{npcDisplayname.Text}"
                        },

                    };
                    PatchVariable patchGiftTaste = new PatchVariable
                    {
                        LogName = "NPC Gift Tastes",
                        Action = "EditData",
                        Target = "Data/NPCGiftTastes",
                        Entries = new Dictionary<string, string>
                        {
                            // [$"{npcSystemName.Text}"] = $"{npcLovedDialog.Text}/{npcLoveData.Items}"
                            [$"{npcSystemName.Text}"] = $"{npcLovedDialog.Text}/" + string.Join(" ", this.GetItems(npcLoveData)) + $"/{npcLikedDialog.Text}/" + string.Join(" ", this.GetItems(npcLikeData)) + $"/{npcDislikeDialog.Text}/" + string.Join(" ", this.GetItems(npcDislikeData)) + $"/{npcHateDialog.Text}/" + string.Join(" ", this.GetItems(npcHateData)) + $"/{npcNeutralDialog.Text}/" + string.Join(" ", this.GetItems(npcNeutralData)) + " "
                        }
                    };
                    PatchVariable patchSprite = new PatchVariable
                    {
                        LogName = "NPC Sprite",
                        Action = "Load",
                        Target = $"Characters/{npcSystemName.Text}",
                        FromFile = $"assets/img/{spriteFile.Text}",
                    };
                    PatchVariable patchPortrait = new PatchVariable
                    {
                        LogName = "NPC Portrait",
                        Action = "Load",
                        Target = $"Portraits/{npcSystemName.Text}",
                        FromFile = $"assets/img/{portraitFile.Text}",
                    };

                    PatchVariable patchSchedule = new PatchVariable
                    {
                        LogName = "Schedule",
                        Action = "Load",
                        Target = $"Characters/schedules/{npcSystemName.Text}",
                        FromFile = $"assets/schedules/Schedule.json",
                    };
                    PatchVariable patchDialogue = new PatchVariable
                    {
                        LogName = "Dialogue",
                        Action = "Load",
                        Target = $"Characters/Dialogue/{npcSystemName.Text}",
                        FromFile = "assets/dialogue/Dialogue.json",
                    };
                    if (string.Equals(dateCheck, "datable"))
                    {
                        PatchVariable patchEngagement = new PatchVariable
                        {
                            LogName = "Engagement Dialogue",
                            Action = "EditData",
                            Target = "Data/EngagementDialogue",
                            Entries = new Dictionary<string, string>
                            {
                                [$"{npcSystemName.Text}0"] = $"{dayOne.Text}",
                                [$"{npcSystemName.Text}1"] = $"{DayTwo.Text}",
                            }
                        };
                        PatchVariable patchMarriage = new PatchVariable
                        {
                            LogName = "Marriage Dialogue",
                            Action = "Load",
                            Target = $"Characters/Dialogue/MarriageDialogue{npcSystemName.Text}",
                            FromFile = "assets/dialogue/MarriageDialogue.json",
                        };
                        ContentVariable contentdatable = new ContentVariable
                        {

                            Format = "1.19.0",
                            Changes = new PatchVariable[] { patchDisposition, patchGiftTaste, patchSprite, patchPortrait, patchSchedule, patchDialogue, patchEngagement, patchMarriage }
                        };
                        string path = Path.Combine($"Export/[CP]{npcSystemName.Text}", "content.json");
                        File.WriteAllText(path, JsonConvert.SerializeObject(contentdatable, Formatting.Indented));
                        MessageBox.Show("Content.json Created! Remember if you press it again it will overwrite!", "NPC Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        ContentVariable content = new ContentVariable
                        {

                            Format = "1.19.0",
                            Changes = new PatchVariable[] { patchDisposition, patchGiftTaste, patchSprite, patchDialogue, patchPortrait, patchSchedule }
                        };

                        string path = Path.Combine($"Export/[CP]{npcSystemName.Text}", "content.json");
                        File.WriteAllText(path, JsonConvert.SerializeObject(content, Formatting.Indented));
                        MessageBox.Show("Content.json Created! Remember if you press it again it will overwrite!", "NPC Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            else
            {
                MessageBox.Show("There is no Mod Folder!! Press Create NPC Folder!", "You Dun Goofed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{npcSystemName.Text}"))
            {

                manifestCreator frmRem = new manifestCreator();
                Form1.exportSystem = this.npcSystemName.Text;
                frmRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("You forgot to make the NPC folder!", "Consequences have never been the same!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void LinkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.modResource.LinkVisited = true;

            System.Diagnostics.Process.Start("https://stardewvalleywiki.com/Modding:Index");

        }

        private void AddLoveList_Click(object sender, EventArgs e)
        {
            npcLoveData.Items.Add(loveData.Value); //adds whatever is placed here.. if it's not an Item ID it's gonna go fux0r3d
        }

        private void LoveRemove_Click(object sender, EventArgs e)
        {
            npcLoveData.Items.Remove(npcLoveData.SelectedItem); //Removes an item if you fuxx3d
        }

        private void AddLikeList_Click(object sender, EventArgs e)
        {
            npcLikeData.Items.Add(likeData.Value);
        }

        private void LikeRemove_Click(object sender, EventArgs e)
        {
            npcLikeData.Items.Remove(npcLikeData.SelectedItem);
        }

        private void AddDislikeList_Click(object sender, EventArgs e)
        {
            npcDislikeData.Items.Add(dislikedData.Value);
        }

        private void DislikeRemove_Click(object sender, EventArgs e)
        {
            npcDislikeData.Items.Remove(npcDislikeData.SelectedItem);
        }

        private void AddHateList_Click(object sender, EventArgs e)
        {
            npcHateData.Items.Add(hateData.Value);
        }

        private void HateRemove_Click(object sender, EventArgs e)
        {
            npcHateData.Items.Remove(npcHateData.SelectedItem);
        }

        private void AddNeutralList_Click(object sender, EventArgs e)
        {
            npcNeutralData.Items.Add(neutralData.Value);
        }

        private void NeutralRemove_Click(object sender, EventArgs e)
        {
            npcNeutralData.Items.Remove(npcNeutralData.SelectedItem);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            
            AboutBox1 frRem = new AboutBox1();
            frRem.ShowDialog();
        }

        private void ScheduleStudio_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{npcSystemName.Text}"))
            {
                scheduleStudio frRem = new scheduleStudio();
                Form1.exportSystem = this.npcSystemName.Text;
                frRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Shouldn't you make the NPC Folder First?", "You accidentally a message box!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateFileStructure_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{npcSystemName.Text}"))
            {
                MessageBox.Show("Folder Exists!  If this is a NPC you were recently working on, DO NOT Generate NPC again unless you intent to overwrite the whole content.json", "Loading Existing NPC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Directory.CreateDirectory("Export");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}/assets");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}/assets/anim");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}/assets/img");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}/assets/schedules");
                Directory.CreateDirectory($"Export/[CP]{npcSystemName.Text}/assets/dialogue");
                MessageBox.Show($"[CP]{npcSystemName.Text} created in the Export Folder!", "Isn't Success nice?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void DialogBoutique_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{npcSystemName.Text}"))
            {
                dialogueBoutique frRem = new dialogueBoutique();
                Form1.exportSystem = this.npcSystemName.Text;
                frRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("You forgot to make the NPC Folder!!", "DERP!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImportSprite_Click(object sender, EventArgs e)
        {
            spriteFile.Text = "spritesheet.png";
            SpritesheetView frRem = new SpritesheetView();
            Form1.exportSystem = this.npcSystemName.Text;
            frRem.ShowDialog();
        }

        private void ImportPortrait_Click(object sender, EventArgs e)
        {
            portraitFile.Text = "portrait.png";
            PortraitView frRem = new PortraitView();
            Form1.exportSystem = this.npcSystemName.Text;
            frRem.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sendtoLike_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcLikeData.Items.Add(item.Id);
        }

        private void sendtoLove_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcLoveData.Items.Add(item.Id);

        }

        private void sendtoDislike_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcDislikeData.Items.Add(item.Id);

        }

        private void sendtoHate_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcHateData.Items.Add(item.Id);

        }

        private void sendtoNeutral_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcNeutralData.Items.Add(item.Id);

        }
    }
}
