using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace NPC_Creator
{
    public partial class Form1 : Form
    {
        public static string exportSystem;
        public string projectName;
        public static string dateCheck;
        public string itemList = Environment.CurrentDirectory + "\\Common Data\\ItemList.json";
        private PatchVariable[] mainPatch;
        Bitmap spriteView;
        Bitmap portView;
        PatchVariable patchEvent = new PatchVariable();
        private List<string> filenames = new List<string>();
        private string[] patchwork;
        //private NPCDisposition NPCDispositionForm;




        public Form1()
        {
            InitializeComponent();

        }
        //Assists with acquiring list data
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
            dateCheck = NPCDisposition.passDate;
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Save Data"))
            {
                Directory.CreateDirectory("Save Data");
            }
            //Acquire Projects
            string[] saveData = System.IO.Directory.GetFiles(Environment.CurrentDirectory + "\\Save Data", "*.npc");
            foreach (string save in saveData)
            {
                string parse = Path.GetFileNameWithoutExtension(save);
                npcNewSystemName.Items.Add(parse);
            }
            //Populate Item list for Gift Taste
            string populateItem = File.ReadAllText(itemList);
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            Directory.CreateDirectory("Save Data");
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemsByID.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"))
            {
                DispoModel model = JsonConvert.DeserializeObject<DispoModel>(File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"));
                this.PopulateLabels(model);
            }
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canDate.date"))
            {
                this.dateLabel.Text = "Datable";
                groupBox9.Enabled = true;
            }
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canNotDat.date"))
            {
                this.dateLabel.Text = "Not Datable";
                groupBox9.Enabled = false;
            }
            
        }
        // GetTileArea handles the graphics
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }


        //Links
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
        //GenerateNPC creates the content.json  
        //Determines how the content.json will be handled depending on the Disposition information.
        private void GenerateNPC_Click(object sender, EventArgs e)
        {

            //Verify datable
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canDate.date"))
            {
                dateCheck = "datable";
            }
            else if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canNotDate.date"))
            {
                dateCheck = "non-datable";
            }

            //MessageBox.Show(dateCheck, "Test", MessageBoxButtons.OK);
            if (Directory.Exists($"Export/[CP]{projectName}"))
            {

                if (string.IsNullOrWhiteSpace(projectName))
                {
                    MessageBox.Show("Please enter a System Name!!", "WHOOPSIE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    if (!File.Exists($"Export/[CP]{projectName}/manifest.json"))
                    {
                        MessageBox.Show("There is no Manifest for your NPC.  We will open the Manifest Creator for you.", "Manifest Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        manifestCreator xrRem = new manifestCreator();
                        Form1.exportSystem = this.projectName;
                        xrRem.ShowDialog();
                    }
                    //Check for Event Files.. if so.. create a list
                    string[] files = Directory.GetFiles(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\Events");
                    
                    foreach (string eventFile in files)
                    {
                        string parse = "Data/Events/" + Path.GetFileNameWithoutExtension(eventFile);
                        filenames.Add(parse);
                    }
                    patchEvent = new PatchVariable
                    {
                        LogName = "Events",
                        Action = "Load",
                        Target = string.Join(", ", filenames),
                        FromFile = "assets/Events/{{TargetWithoutPath}}.json"
                    };
                    PatchVariable patchDisposition = new PatchVariable
                    {
                        LogName = "NPC Manifestation",
                        Action = "Include",
                        FromFile = "assets/disposition/Disposition.json"

                    };
                    PatchVariable patchGiftTaste = new PatchVariable
                    {
                        LogName = "NPC Gift Tastes",
                        Action = "EditData",
                        Target = "Data/NPCGiftTastes",
                        Entries = new Dictionary<string, string>
                        {
                            // [$"{projectName}"] = $"{npcLovedDialog.Text}/{npcLoveData.Items}"
                            [$"{projectName}"] = $"{npcLovedDialog.Text}/" + string.Join(" ", this.GetItems(npcLoveData)) + $"/{npcLikedDialog.Text}/" + string.Join(" ", this.GetItems(npcLikeData)) + $"/{npcDislikeDialog.Text}/" + string.Join(" ", this.GetItems(npcDislikeData)) + $"/{npcHateDialog.Text}/" + string.Join(" ", this.GetItems(npcHateData)) + $"/{npcNeutralDialog.Text}/" + string.Join(" ", this.GetItems(npcNeutralData)) + " "
                        }
                    };
                    PatchVariable patchSprite = new PatchVariable
                    {
                        LogName = "NPC Sprite",
                        Action = "Load",
                        Target = $"Characters/{projectName}",
                        FromFile = $"assets/img/{spriteFile.Text}",
                    };
                    PatchVariable patchPortrait = new PatchVariable
                    {
                        LogName = "NPC Portrait",
                        Action = "Load",
                        Target = $"Portraits/{projectName}",
                        FromFile = $"assets/img/{portraitFile.Text}",
                    };

                    PatchVariable patchSchedule = new PatchVariable
                    {
                        LogName = "Schedule",
                        Action = "Load",
                        Target = $"Characters/schedules/{projectName}",
                        FromFile = $"assets/schedules/schedule.json",
                    };
                    PatchVariable patchSchDia = new PatchVariable
                    {
                        LogName = "Schedule Dialogue",
                        Action = "Load",
                        Target = $"Strings/schedules/{projectName}",
                        FromFile = "assets/schedules/scheduleDialogue.json",
                    };

                    PatchVariable patchAnim = new PatchVariable
                    {
                        LogName = "Animation Frames",
                        Action = "Include",
                        FromFile = $"assets/anim/Animations.json",
                    };

                    PatchVariable patchDialogue = new PatchVariable
                    {
                        LogName = "Dialogue",
                        Action = "Load",
                        Target = $"Characters/Dialogue/{projectName}",
                        FromFile = "assets/dialogue/Dialogue.json",
                    };
                    PatchVariable patchEngagement = new PatchVariable
                    {
                        LogName = "Engagement Dialogue",
                        Action = "EditData",
                        Target = "Data/EngagementDialogue",
                        Entries = new Dictionary<string, string>
                        {
                            [$"{projectName}0"] = $"{dayOne.Text}",
                            [$"{projectName}1"] = $"{DayTwo.Text}",
                        }
                    };
                    PatchVariable patchMarriage = new PatchVariable
                    {
                        LogName = "Marriage Dialogue",
                        Action = "Load",
                        Target = $"Characters/Dialogue/MarriageDialogue{projectName}",
                        FromFile = "assets/dialogue/MarriageDialogue.json",
                    };
                    
                    List<PatchVariable> createPatch = new List<PatchVariable> { patchDisposition, patchGiftTaste, patchSprite, patchPortrait, patchSchedule, patchDialogue, patchEngagement, patchMarriage };
                    if (File.Exists($"Export/[CP]{projectName}/assets/anim/Animations.json"))
                        createPatch.Add(patchAnim);
                    if (File.Exists($"Export/[CP]{projectName}/assets/schedules/scheduleDialogue.json"))
                        createPatch.Add(patchSchDia);
                    if (dateCheck == "datable")
                    {
                        createPatch.Add(patchMarriage);
                        createPatch.Add(patchEngagement);
                    }
                    if (filenames.Count != 0)
                        createPatch.Add(patchEvent);
                    mainPatch = createPatch.ToArray();
                    ContentVariable createJson = new ContentVariable
                    {

                        Format = "1.21.0",
                        Changes = mainPatch
                    };
                    string path = Path.Combine($"Export/[CP]{projectName}", "content.json");
                    File.WriteAllText(path, JsonConvert.SerializeObject(createJson, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    MessageBox.Show("Content.json Created! Remember if you press it again it will overwrite!", "NPC Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}");
                    createPatch.Clear();
                }
            }
            else
            {
                MessageBox.Show("There is no Mod Folder!! Press Create NPC Folder!", "You Dun Goofed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Manifest Creator creates the Manifest for the Mod.. it must be run.
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{projectName}"))
            {

                manifestCreator frmRem = new manifestCreator();
                Form1.exportSystem = this.projectName;
                frmRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("You forgot to make the NPC folder!", "Consequences have never been the same!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //More Links
        private void LinkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.modResource.LinkVisited = true;

            System.Diagnostics.Process.Start("https://stardewvalleywiki.com/Modding:Index");

        }


        private void LoveRemove_Click(object sender, EventArgs e)
        {
            npcLoveData.Items.Remove(npcLoveData.SelectedItem); //Removes an item if you fuxx3d
            GiftListSave();

        }


        private void LikeRemove_Click(object sender, EventArgs e)
        {
            npcLikeData.Items.Remove(npcLikeData.SelectedItem);
            GiftListSave();

        }


        private void DislikeRemove_Click(object sender, EventArgs e)
        {
            npcDislikeData.Items.Remove(npcDislikeData.SelectedItem);
            GiftListSave();

        }

        private void HateRemove_Click(object sender, EventArgs e)
        {
            npcHateData.Items.Remove(npcHateData.SelectedItem);
            GiftListSave();

        }


        private void NeutralRemove_Click(object sender, EventArgs e)
        {
            npcNeutralData.Items.Remove(npcNeutralData.SelectedItem);
            GiftListSave();

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

            AboutBox1 frRem = new AboutBox1();
            frRem.ShowDialog();
        }
        //Schedule Studio handles schedule dialog, Animations, and the Schedule itself.
        private void ScheduleStudio_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{projectName}"))
            {
                scheduleStudio frRem = new scheduleStudio();
                Form1.exportSystem = this.projectName;
                frRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cannot start without a project name!", "Opps!", MessageBoxButtons.OK);
                /*MessageBox.Show("No Project Detected!\nEntering Independent Mode", "You accidentally a message box!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                scheduleStudio frRem = new scheduleStudio();
                frRem.Text = "Schedule Studio - Independent Mode";
                frRem.ShowDialog();*/

            }
        }
        //Create the NPC File Structure
        private void CreateFileStructure_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(npcNewSystemName.Text))
            {
                //Fist Clear old Entries
                ResetAll();
                CheckFileStructure();
                //MessageBox.Show(npcNewSystemName.Text, "Test");
                //Check if existing Project has a .date file; if not.. Advise to create Disposition
                if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"))
                {
                    DispoModel model = JsonConvert.DeserializeObject<DispoModel>(File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"));
                    this.PopulateLabels(model);
                }
                if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canDate.date"))
                {
                    dateCheck = "datable";
                    this.dateLabel.Text = "Datable";
                    groupBox9.Enabled = true;
                }
                else if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canNotDat.date"))
                {
                    dateCheck = "non-datable";
                    this.dateLabel.Text = "Not Datable";
                    groupBox9.Enabled = false;
                }
                if (Directory.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData"))
                {
                    try
                    {
                        npcLoveData.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveList.txt"));
                        npcLikeData.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeList.txt"));
                        npcNeutralData.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralList.txt"));
                        npcDislikeData.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeList.txt"));
                        npcHateData.Items.AddRange(System.IO.File.ReadAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateList.txt"));
                        npcLovedDialog.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveDialog.txt");
                        npcLikedDialog.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeDialog.txt");
                        npcNeutralDialog.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralDialog.txt");
                        npcDislikeDialog.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeDialog.txt");
                        npcHateDialog.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateDialog.txt");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No Gift Tastes Detected!\nLeaving Blank!", "No saved Data", MessageBoxButtons.OK);
                    }
                }
                if (Directory.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement"))
                {
                    try
                    {
                        dayOne.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementA.txt");
                        DayTwo.Text = System.IO.File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementB.txt");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No Saved Engagement Data!\nLeave Default!", "No Saved Data", MessageBoxButtons.OK);
                    }
                }
                groupBox1.Text = $"Project: [CP]{npcNewSystemName.Text}";
                if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}.npc"))
                {
                    //projectName = npcNewSystemName.SelectedItem.ToString();
                    projectName = npcNewSystemName.Text;
                    if (!File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canDate.date") && !File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canNotDat.date"))
                    {
                        MessageBox.Show("This saved NPC has not been updated with the new Date Check.\nPlease re-save your Disposition!", "Update Old Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                projectName = npcNewSystemName.Text;
                File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}.npc", "");
                if (Directory.Exists($"Export/[CP]{npcNewSystemName.Text}"))
                {
                    MessageBox.Show("Project Loaded Successfully", "Loading NPC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (!File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"))
                    {
                        MessageBox.Show("No Disposition found!!\nPlease create a Disposition for project.", "No NPCDisposition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NPCDisposition fRem = new NPCDisposition();
                        Form1.exportSystem = projectName;
                        fRem.FormClosed += NPCDisposition_FormClosed;
                        fRem.ShowDialog();

                    }
                    if (File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\spritesheet.png"))
                    {
                        spriteFile.Text = "spritesheet.png";
                        try
                        {
                            //Get Spritesheet
                            spriteView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\spritesheet.png");
                            Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                            Bitmap spriteFrame = spriteView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                            spriteBox.Image = spriteFrame;
                            spriteBox.Refresh();



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\portrait.png"))
                    {
                        portraitFile.Text = "portrait.png";
                        try
                        {
                            //Get Spritesheet
                            portView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\portrait.png");
                            Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                            Bitmap spriteFrame = portView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                            portraitBox.Image = spriteFrame;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    Directory.CreateDirectory("Export");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets/anim");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets/img");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets/schedules");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets/dialogue");
                    Directory.CreateDirectory($"Export/[CP]{npcNewSystemName.Text}/assets/disposition");
                    Directory.CreateDirectory($"Save Data");
                    Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData");
                    Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/GiftTasteData");
                    Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/Engagement");



                    MessageBox.Show($"[CP]{projectName} created in the Export Folder!\nCreate your Disposition!", "Isn't Success nice?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    NPCDisposition fRem = new NPCDisposition();
                    Form1.exportSystem = projectName;
                    fRem.FormClosed += NPCDisposition_FormClosed;
                    fRem.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("The System Name Cannot be Blank!!\nPlease Create or Select a System Name!", "Blank Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DialogBoutique_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"Export/[CP]{projectName}"))
            {
                dialogueBoutique frRem = new dialogueBoutique();
                Form1.exportSystem = this.projectName;
                frRem.ShowDialog();
            }
            else
            {
                MessageBox.Show("No NPC Project Loaded!\n Starting in Independant Mode!", "I need no man!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dialogueBoutique frRem = new dialogueBoutique();
                frRem.Text = "Dialogue Boutique: Independant Mode";
                frRem.ShowDialog();
            }
        }
        //Load Spritesheet
        private void ImportSprite_Click(object sender, EventArgs e)
        {
            spriteFile.Text = "spritesheet.png";
            try
            {
                OpenFileDialog importDialog = new OpenFileDialog();

                if (importDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy(importDialog.FileName, Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\spritesheet.png");

                    //Bitmap addSprite = new Bitmap(spriteLocation);
                    //spriteSheet.Image = addSprite;
                    try
                    {
                        //Get Spritesheet
                        spriteView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\spritesheet.png");
                        Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                        Bitmap spriteFrame = spriteView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                        spriteBox.Image = spriteFrame;
                        spriteBox.Refresh();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please ensure:\n -The image is not already in the img folder.\n -That you have created a system folder.", "Flagarant Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            SpritesheetView frRem = new SpritesheetView();
            Form1.exportSystem = this.projectName;
            frRem.ShowDialog();
        }
        //Load Portrait
        private void ImportPortrait_Click(object sender, EventArgs e)
        {
            portraitFile.Text = "portrait.png";
            string spriteLocation = Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\portrait.png";
            try
            {
                OpenFileDialog importDialog = new OpenFileDialog();

                if (importDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.Copy(importDialog.FileName, spriteLocation);

                    try
                    {
                        //Get Spritesheet
                        portView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\portrait.png");
                        Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                        Bitmap spriteFrame = portView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                        portraitBox.Image = spriteFrame;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Please ensure:\n -The image is not already in the img folder.\n -That you have created a system folder.", "Flagarant Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PortraitView frRem = new PortraitView();
            Form1.exportSystem = this.projectName;
            frRem.ShowDialog();
        }


        private void sendtoLike_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcLikeData.Items.Add(item.Id);
            itemsByID.Items.Remove(itemsByID.SelectedItem);
            GiftListSave();
        }

        private void sendtoLove_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcLoveData.Items.Add(item.Id);
            itemsByID.Items.Remove(itemsByID.SelectedItem);
            GiftListSave();
        }

        private void sendtoDislike_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcDislikeData.Items.Add(item.Id);
            itemsByID.Items.Remove(itemsByID.SelectedItem);
            GiftListSave();
        }

        private void sendtoHate_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcHateData.Items.Add(item.Id);
            itemsByID.Items.Remove(itemsByID.SelectedItem);
            GiftListSave();
        }

        private void sendtoNeutral_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemsByID.SelectedItem;
            npcNeutralData.Items.Add(item.Id);
            itemsByID.Items.Remove(itemsByID.SelectedItem);
            GiftListSave();
        }

        private void npcDispoForm_Click(object sender, EventArgs e)
        {
            NPCDisposition fRem = new NPCDisposition();
            Form1.exportSystem = npcNewSystemName.Text;
            fRem.FormClosed += NPCDisposition_FormClosed;
            fRem.ShowDialog();
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(npcNewSystemName.Text))
            {
                MessageBox.Show("You have not created or Loaded a Project!", "Hang on a minute!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else Process.Start(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            Process.Start("https://discord.gg/uSGNKNf");
        }
        //Save all will make several lists and files to signify Gift Tastes and Dialog from the main page
        private void saveAll_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData"))
            {
                Directory.CreateDirectory($"Save Data");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/GiftTasteData");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/Engagement");

            }
            //Acquire Love list
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveList.txt", GetItems(npcLoveData));
            //Acquire Like List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeList.txt", GetItems(npcLikeData));
            //Acquire neutral List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralList.txt", GetItems(npcNeutralData));
            //Acquire Dislike List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeList.txt", GetItems(npcDislikeData));
            //Acquire Hate List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateList.txt", GetItems(npcHateData));
            //Acquire Loved Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveDialog.txt", $"{npcLovedDialog.Text}");
            //Acquire Liked Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeDialog.txt", $"{npcLikedDialog.Text}");
            //Acquire Neutral Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralDialog.txt", $"{npcNeutralDialog.Text}");
            //Acquire Dislike Dialoge
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeDialog.txt", $"{npcDislikeDialog.Text}");
            //Acquire Hate Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateDialog.txt", $"{npcHateDialog.Text}");
            //Acquire Engagement Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementA.txt", $"{dayOne.Text}");
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementB.txt", $"{DayTwo.Text}");
            MessageBox.Show("Saved all Gift Taste and Engagement Data!", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Label Controls
        private void PopulateLabels(DispoModel model)
        {
            this.ageLabel.Text = model.lstAge;
            this.genderLabel.Text = model.lstGender;
            this.locationLabel.Text = $"{model.lstMapSpawn} {model.varMapX} {model.varMapY}";
            this.displayLabel.Text = model.npcstrName;
            this.bdayLabel.Text = $"{model.lstBdaySeas} {model.varBday}";

        }
        void NPCDisposition_FormClosed(object ender, FormClosedEventArgs e)
        {


            //Check if existing Project has a .date file; if not.. Advise to create Disposition
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"))
            {
                DispoModel model = JsonConvert.DeserializeObject<DispoModel>(File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Dispo.json"));
                this.PopulateLabels(model);
            }
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canDate.date"))
            {
                dateCheck = "datable";
                this.dateLabel.Text = "Datable";
                groupBox9.Enabled = true;
            }
            else if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\canNotDat.date"))
            {
                dateCheck = "non-datable";
                this.dateLabel.Text = "Not Datable";
                groupBox9.Enabled = false;
            }

        }
        private void ResetAll()
        {
            npcDislikeData.Items.Clear();
            npcHateData.Items.Clear();
            npcLikeData.Items.Clear();
            npcLoveData.Items.Clear();
            npcNeutralData.Items.Clear();
            npcLovedDialog.Text = "Oh wow this is amazing!  Thank you!";
            npcLikedDialog.Text = "How nice of you, this is great.";
            npcDislikeDialog.Text = "Oh.. well it's the though that counts I guess.";
            npcHateDialog.Text = "Gross... You're Gross...";
            dayOne.Text = "I am so happy!$1";
            DayTwo.Text = "I'm so nervous for tomorrow.$4";
            itemsByID.Items.Clear();
            string populateItem = File.ReadAllText(itemList);
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            Directory.CreateDirectory("Save Data");
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemsByID.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }

        }
        public void CheckFileStructure()
        {
            projectName = npcNewSystemName.Text;
            Directory.CreateDirectory("Export");
            Directory.CreateDirectory($"Export/[CP]{projectName}");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/anim");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/img");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/schedules");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/dialogue");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/disposition");
            Directory.CreateDirectory($"Save Data");
            Directory.CreateDirectory($"Save Data/{projectName}_saveData");
            Directory.CreateDirectory($"Save Data/{projectName}_saveData/GiftTasteData");
            Directory.CreateDirectory($"Save Data/{projectName}_saveData/Engagement");
            Directory.CreateDirectory($"Export/[CP]{projectName}/assets/Events");

        }
        //Click Reset Items List
        private void button1_Click_1(object sender, EventArgs e)
        {
            itemsByID.Items.Clear();
            string populateItem = File.ReadAllText(itemList);
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            Directory.CreateDirectory("Save Data");
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemsByID.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }

        }
        //Reset all Gift Item Lists
        private void giftClear_Click(object sender, EventArgs e)
        {
            npcDislikeData.Items.Clear();
            npcHateData.Items.Clear();
            npcLikeData.Items.Clear();
            npcLoveData.Items.Clear();
            npcNeutralData.Items.Clear();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Reset all Removes Gift Tastes and all Dialogue on this page!\nProceed?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(reset == DialogResult.Yes)
            {
                ResetAll();
            }
            if(reset == DialogResult.No)
            {
                MessageBox.Show("Action Canceled.", "CANCEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Check for missing files
        private void fileCheck_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(npcNewSystemName.Text))
            {
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\disposition\\Disposition.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s Disposition Found!", "NPCDisposition Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\disposition\\Disposition.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text} does not seem to have a Disposition", "NPCDisposition Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\dialogue\\Dialogue.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s Dialogue Found!", "Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\dialogue\\Dialogue.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text} does not seem to have a Dialogue File", "Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\schedules\\schedule.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s Schedule has been found!", "Schedule Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\schedules\\schedule.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text} does not seem to have a Schedule.", "Schedule Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\schedules\\scheduleDialogue.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s Schedule Dialogue has been found!", "Schedule Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\schedules\\scheduleDialogue.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text} does not have a Schedule Dialogue.\nThis will not cause an Error to your NPC\nUnless the schedule calls for dialogue.", "Schedule Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\anim\\Animations.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s Animations file Found!", "Animation Description Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\anim\\Animations.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text} does not seem to have an Animations File.\nThis will not cause an error to your NPC\nUnless your schedule calls for an Animation.", "Animation Description Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(dateCheck == "datable")
                {
                    if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\dialogue\\MarriageDialogue.json"))
                    {
                        MessageBox.Show($"{npcNewSystemName.Text}'s Marriage Dialogue Found!", "Marriage Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\dialogue\\MarriageDialogue.json"))
                    {
                        MessageBox.Show($"{npcNewSystemName.Text} does not seem to have Marriage Dialogue.\nIt is important to create this file!", "Marriage Dialogue Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\portrait.png"))
                {
                    MessageBox.Show("Portraits Found!", "Portrait Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\portrait.png"))
                {
                    MessageBox.Show("No Portraits Found!\nBe sure to add some!", "Portrait Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet"))
                {
                    MessageBox.Show("Spritesheet Found!", "Spritesheet Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet.png"))
                {
                    MessageBox.Show("No Spritesheet Found!\nBe sure to add some!", "Spritesheet Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\content.json"))
                {
                    MessageBox.Show($"{npcNewSystemName.Text}'s content.json has been found!", "Content check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\content.json"))
                {
                    MessageBox.Show("content.json not found!\nBe sure to Generate the content.json", "Content Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\manifest.json"))
                {
                    MessageBox.Show("Manifest has been found!", "Manifest Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!File.Exists(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\manifest.json"))
                {
                    MessageBox.Show("Manifest has not been created.\nBe sure to run the Manifest Creator!", "Manifest Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void createTemplates_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(npcNewSystemName.Text))
            {
                try
                {
                    File.Copy(Environment.CurrentDirectory + "\\Common Data\\Templates(Do not edit these)\\Portrait_template.png", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\portrait.png");
                    File.Copy(Environment.CurrentDirectory + "\\Common Data\\ReadMes\\Portrait Template Readme.txt", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\Portrait_Template_Readme.txt");
                    if(ageLabel.Text == "adult" || ageLabel.Text == "teen")
                    {
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\Templates(Do not edit these)\\Adult_sprite_template.png", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet.png");
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\ReadMes\\Spritesheet Template Readme.txt", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\Spritesheet_Template_Readme.txt");
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\Templates(Do not edit these)\\spritesheet map.png", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet_map.png");

                    }
                    if (ageLabel.Text == "child")
                    {
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\Templates(Do not edit these)\\Child_sprite_template.png", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet.png");
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\ReadMes\\Spritesheet Template Readme.txt", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\Spritesheet_Template_Readme.txt");
                        File.Copy(Environment.CurrentDirectory + "\\Common Data\\Templates(Do not edit these)\\spritesheet map.png", Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img\\spritesheet_map.png");
                    }
                    spriteFile.Text = "spritesheet.png";
                    portraitFile.Text = "portrait.png";
                    try
                    {
                        //Get Spritesheet
                        spriteView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\spritesheet.png");
                        Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 16, tileHeight: 32, sheetWidthInTiles: 4);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                        Bitmap spriteFrame = spriteView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                        spriteBox.Image = spriteFrame;
                        spriteBox.Refresh();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        //Get Spritesheet
                        portView = new Bitmap(Environment.CurrentDirectory + $"\\Export\\[CP]{projectName}\\assets\\img\\portrait.png");
                        Rectangle pixelAreaForTile = this.GetTileArea(tileIndex: 0, tileWidth: 64, tileHeight: 64, sheetWidthInTiles: 2);               // Rectangle rect = new Rectangle(xmin, ymin, xmaximum, ymaximum);
                        Bitmap spriteFrame = portView.Clone(pixelAreaForTile, PixelFormat.DontCare);
                        portraitBox.Image = spriteFrame;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n You cannot exceed the number of frames your Spritesheet has!!", "Why can't I hold all these Frames?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    importSprite.Enabled = false;
                    importPortrait.Enabled = false;
                    DialogResult imgTemplate = MessageBox.Show("Templates have been created!!\nWould you like to be sent to your image folder?", "Templates Created!", MessageBoxButtons.YesNo);
                    if (imgTemplate == DialogResult.Yes)
                    {
                        Process.Start(Environment.CurrentDirectory + $"\\Export\\[CP]{npcNewSystemName.Text}\\assets\\img");
                    }
                    if (imgTemplate == DialogResult.No)
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void GiftListSave()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData"))
            {
                Directory.CreateDirectory($"Save Data");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/GiftTasteData");
                Directory.CreateDirectory($"Save Data/{npcNewSystemName.Text}_saveData/Engagement");

            }
            //Acquire Love list
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveList.txt", GetItems(npcLoveData));
            //Acquire Like List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeList.txt", GetItems(npcLikeData));
            //Acquire neutral List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralList.txt", GetItems(npcNeutralData));
            //Acquire Dislike List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeList.txt", GetItems(npcDislikeData));
            //Acquire Hate List
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateList.txt", GetItems(npcHateData));
            //Acquire Loved Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LoveDialog.txt", $"{npcLovedDialog.Text}");
            //Acquire Liked Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\LikeDialog.txt", $"{npcLikedDialog.Text}");
            //Acquire Neutral Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\NeutralDialog.txt", $"{npcNeutralDialog.Text}");
            //Acquire Dislike Dialoge
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\DislikeDialog.txt", $"{npcDislikeDialog.Text}");
            //Acquire Hate Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\GiftTasteData\\HateDialog.txt", $"{npcHateDialog.Text}");
            //Acquire Engagement Dialogue
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementA.txt", $"{dayOne.Text}");
            System.IO.File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{npcNewSystemName.Text}_saveData\\Engagement\\EngagementB.txt", $"{DayTwo.Text}");

        }

        private void createEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Studio does not account for your NPCs and is completely standalone.\nBe sure to add what you need for events in the appropriate areas.", "Event Studio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Event_Studio frRem = new Event_Studio();
            exportSystem = npcNewSystemName.Text;
            frRem.ShowDialog();
        }
    }
}
