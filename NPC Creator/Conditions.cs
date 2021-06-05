using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class Conditions : Form
    {
        List<string> conditionCommands = new List<string>();
        List<string> eventCommandManifest = new List<string>();
        public Conditions()
        {
            InitializeComponent();
        }
        public void addConditiontoList(string data)
        {
            conditionsList.Items.Add(data);
        }
        public void addCommandtoList(string data)
        {
            eventCommandList.Items.Add(data);
        }
        public void ClearTempFiles()
        {
            if (Directory.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation"))
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
                {
                    File.Delete(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt");
                }
            }
        }
        public void MoveUp()
        {
            MoveItem(-1);
        }
        public void MoveDown()
        {
            MoveItem(1);
        }
        public void MoveItem(int direction)
        {
            //check if valid
            if (eventCommandList.SelectedItem == null || eventCommandList.SelectedIndex < 0)
                return; //Nothing selected
            //create new index using move direction
            int newIndex = eventCommandList.SelectedIndex + direction;
            //check bounds
            if (newIndex < 0 || newIndex >= eventCommandList.Items.Count)
                return; //Out of Range.. do nothing
            object selected = eventCommandList.SelectedItem;

            //Delete old instance
            eventCommandList.Items.Remove(selected);
            //place on new spot
            eventCommandList.Items.Insert(newIndex, selected);
            //restore selection
            eventCommandList.SetSelected(newIndex, true);
        }

        private void startEvent_Click(object sender, EventArgs e)
        {
            if(mainEvent.Value == 0 && string.IsNullOrWhiteSpace(subEvent.Text))
            {
                MessageBox.Show("You must create an Event ID of some sorts before you begin!", "Cannot Continue!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(mainEvent.Value > 0 && !string.IsNullOrWhiteSpace(subEvent.Text))
            {
                MessageBox.Show("You cannot use both types of IDs!\nUse one or the other!", "Confused Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mainEvent.Value = 0;
                subEvent.Text = "";
            }
            if(mainEvent.Value > 0 && string.IsNullOrWhiteSpace(subEvent.Text))
            {
                conditionsGroup.Enabled = true;
                groupBox1.Enabled = false;
                conditionsGroup.Text = $"Conditions for Event ID {mainEvent.Value}";
            }
            if(mainEvent.Value == 0 && !string.IsNullOrWhiteSpace(subEvent.Text))
            {
                conditionsGroup.Enabled = false;
                groupBox1.Enabled = false;
                conditionsGroup.Text = "Sub Events have no Conditions";
                eventGroup.Text = $"Event Commands for {subEvent.Text}";
                eventGroup.Enabled = true;
            }
        }

        private void Conditions_Load(object sender, EventArgs e)
        {
            conditionsGroup.Enabled = false;
            ClearTempFiles();
        }
        private void DialogNotInProg_Click(object sender, EventArgs e)
        {
            DialogID frRem = new DialogID();
            frRem.Text = $"Dialogue Not In Progress for {mainEvent.Value}";
            frRem.ShowDialog();
        }

        private void NotFestivalToday_Click(object sender, EventArgs e)
        {
            conditionsList.Items.Add("F");
        }

        private void NotFestinDays_Click(object sender, EventArgs e)
        {
            Not_Festival_in_X frRem = new Not_Festival_in_X();
            frRem.Text = $"Set Parameter for Event {mainEvent.Value}";
            frRem.ShowDialog();
        }

        private void notDays_Click(object sender, EventArgs e)
        {
            Not_These_Days frRem = new Not_These_Days();
            frRem.Text = $"{mainEvent.Value} will not activate on these days.";
            frRem.ShowDialog();
        }

        private void probabilityCheck_Click(object sender, EventArgs e)
        {
            Event_Chance frRem = new Event_Chance();
            frRem.Text = "Percent Chance for Trigger";
            frRem.ShowDialog();
        }

        private void InvisNPC_Click(object sender, EventArgs e)
        {
            InvisibleNPC frRem = new InvisibleNPC();
            frRem.Text = "Select a NPC to be checked for invisibility.";
            frRem.ShowDialog();
        }

        private void WeatherCond_Click(object sender, EventArgs e)
        {
            WeatherCondition frRem = new WeatherCondition();
            frRem.Text = "Select Weather Trigger";
            frRem.ShowDialog();
        }

        private void yearCheck_Click(object sender, EventArgs e)
        {
            Year_Check frRem = new Year_Check();
            frRem.Text = $"Valid Year for {mainEvent.Value}";
            frRem.ShowDialog();
        }

        private void notSeason_Click(object sender, EventArgs e)
        {
            Choose_Season frRem = new Choose_Season();
            frRem.Text = "Choose a Season";
            frRem.ShowDialog();
        }

        private void DateNPC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All NPCs will be listed due to mods changing their dispositions.\nIf none of those mods are present you will make an impossible condition.", "Before You Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SelectDateNPC frRem = new SelectDateNPC();
            frRem.Text = "Select NPC";
            frRem.ShowDialog();
        }

        private void JojaDone_Click(object sender, EventArgs e)
        {
            conditionsList.Items.Add("J");

        }

        private void FHwithUPG_Click(object sender, EventArgs e)
        {
            conditionsList.Items.Add("L");
        }

        private void MoneyCondition_Click(object sender, EventArgs e)
        {
            HasMoney frREm = new HasMoney();
            frREm.Text = "Currently Held Money";
            frREm.ShowDialog();
        }

        private void MarriedNPC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All NPCs will be listed due to mods changing their dispositions.\nIf none of those mods are present you will make an impossible condition.", "Before You Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MarriedCheck frRem = new MarriedCheck();
            frRem.Text = "Select NPC from list";
            frRem.ShowDialog();
        }

        private void SecretNote_Click(object sender, EventArgs e)
        {
            SecretNotes frRem = new SecretNotes();
            frRem.Text = "Secret Notes";
            frRem.ShowDialog();
        }

        private void XYPos_Click(object sender, EventArgs e)
        {
            FarmerXY frRem = new FarmerXY();
            frRem.Text = "Farmer's Position";
            frRem.ShowDialog();
        }

        private void BottomMineCount_Click(object sender, EventArgs e)
        {
            BottomOfMine frRem = new BottomOfMine();
            frRem.Text = "Set Variable";
            frRem.ShowDialog();
        }

        private void OpenInvSlots_Click(object sender, EventArgs e)
        {
            OpenInvSlots frRem = new OpenInvSlots();
            frRem.Text = "Just remember you still hold tools!";
            frRem.ShowDialog();
        }

        private void SeenEvent_Click(object sender, EventArgs e)
        {
            HasSeenEventCondition frRem = new HasSeenEventCondition();
            frRem.Text = "You can put multiple IDs..";
            frRem.ShowDialog();
        }

        private void FPNPC_Click(object sender, EventArgs e)
        {
            FriendshipPoints frRem = new FriendshipPoints();
            frRem.Text = "Add Friendship requirements";
            frRem.ShowDialog();
        }

        private void FarmerGender_Click(object sender, EventArgs e)
        {
            FarmerGender frRem = new FarmerGender();
            frRem.Text = "Farmer Gender";
            frRem.ShowDialog();
        }

        private void HasItem_Click(object sender, EventArgs e)
        {
            HasItem frRem = new HasItem();
            frRem.Text = "Item needed for Event";
            frRem.ShowDialog();
        }

        private void PlayedDays_Click(object sender, EventArgs e)
        {
            DaysPlayed frRem = new DaysPlayed();
            frRem.Text = "Let's do a Long play!";
            frRem.ShowDialog();
        }

        private void NotSeenEvent_Click(object sender, EventArgs e)
        {
            NotSeenEvent frRem = new NotSeenEvent();
            frRem.Text = "You can put Multiple IDs";
            frRem.ShowDialog();
        }

        private void NotSeenMail_Click(object sender, EventArgs e)
        {
            NotSeenMail frRem = new NotSeenMail();
            frRem.Text = "Be sure to spell mailIDs correctly";
            frRem.ShowDialog();
        }

        private void EarnedMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This measures total earned in the game.\nThis means the Farmer doesn't have to have the amount.\nThe Farmer has to have earned this total.", "Before you begin..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EarnedMoney frRem = new EarnedMoney();
            frRem.Text = "Earned Money";
            frRem.ShowDialog();
        }

        private void SeenMail_Click(object sender, EventArgs e)
        {
            SeenMail frRem = new SeenMail();
            frRem.Text = "Be sure to spell MailIDs correctly";
            frRem.ShowDialog();
        }

        private void NotMarried_Click(object sender, EventArgs e)
        {
            NotMarriedToNPC frRem = new NotMarriedToNPC();
            frRem.Text = "Not Married to NPC";
            frRem.ShowDialog();
        }

        private void NPCPresent_Click(object sender, EventArgs e)
        {
            WhoisPresent frRem = new WhoisPresent();
            frRem.Text = "Select or type a NPC name";
            frRem.ShowDialog();
        }

        private void ResponseID_Click(object sender, EventArgs e)
        {
            HasResponse frRem = new HasResponse();
            frRem.Text = "Response ID needed";
            frRem.ShowDialog();
        }

        private void ShipItems_Click(object sender, EventArgs e)
        {
            ShippedItems frRem = new ShippedItems();
            frRem.Text = "Please create manifest for item shipping requirements.";
            frRem.ShowDialog();
        }

        private void TimeFrame_Click(object sender, EventArgs e)
        {
            TimeFrame frRem = new TimeFrame();
            frRem.Text = "Minimum and Maximum Time";
            frRem.ShowDialog();
        }

        private void SeasonDay_Click(object sender, EventArgs e)
        {
            DayInSeason frRem = new DayInSeason();
            frRem.Text = "Choose a number.";
            frRem.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            conditionsList.Items.Remove(conditionsList.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            conditionsList.Items.Clear();
        }

        private void EventStartMain_Click(object sender, EventArgs e)
        {
            StartEventingWindow frRem = new StartEventingWindow();
            frRem.Text = $"Initial Event Chain for {mainEvent.Value}";
            eventGroup.Enabled = true;
            conditionsGroup.Enabled = false;
            eventGroup.Text = $"Event Commands for {mainEvent.Value}";
            frRem.ShowDialog();
        }

        private void MailLetter_Click(object sender, EventArgs e)
        {
            MailALetterInterface frRem = new MailALetterInterface();
            frRem.Text = "Mail a Letter";
            frRem.ShowDialog();
        }
        //Event Commands start here
        private void AddBigPropCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Studio does not know what map you're using.  Be sure to know your coordinates.", "Before You Continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(!File.Exists(Environment.CurrentDirectory + "\\Common Data\\Craftables.png"))
            {
                MessageBox.Show("You can place a copy of Craftables.png in your Common Data Folder for visual Aid");
            }
            AddBigPropWindow frRem = new AddBigPropWindow();
            frRem.Text = "Select a Big Prop";
            frRem.ShowDialog();
        }

        private void AddTopicCommand_Click(object sender, EventArgs e)
        {
            AddConversationTopic frRem = new AddConversationTopic();
            frRem.Text = "Add a new Conversation Topic";
            frRem.ShowDialog();
        }

        private void AddRecipeCommand_Click(object sender, EventArgs e)
        {
            AddCookingRecipe frRem = new AddCookingRecipe();
            frRem.Text = "Cooking Recipes";
            frRem.ShowDialog();
        }

        private void AddCraftingCommand_Click(object sender, EventArgs e)
        {
            AddCraftingRecipe frRem = new AddCraftingRecipe();
            frRem.Text = "Crafting Recipes";
            frRem.ShowDialog();
        }

        private void AddLanternCommand_Click(object sender, EventArgs e)
        {
            AddLantern frRem = new AddLantern();
            frRem.Text = "Create Lantern";
            frRem.ShowDialog();
        }

        private void MailRecievedCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Command doesn't mail a letter.\nIt only sets the mail ID as seen.", "Before you continue...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMailReceived frRem = new AddMailReceived();
            frRem.Text = "Set Mail ID as Received";
            frRem.ShowDialog();
        }

        private void AddObjectCommand_Click(object sender, EventArgs e)
        {
            AddObject frRem = new AddObject();
            frRem.Text = "Add Object";
            frRem.ShowDialog();
        }

        private void AddQuestCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quest Modding is not covered in NPC Creator.\nIt is not recommended you use this unless you know what you're doing.", "Advanced users only", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddQuest frRem = new AddQuest();
            frRem.Text = "Add Quest";
            frRem.ShowDialog();
        }

        private void AddTemporaryActorCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("While basic controls are certain to work, the Animal data is unfinished and not recommended for use.\nUse only if you're an advanced user!", "Incomplete understanding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TemporaryActor frRem = new TemporaryActor();
            frRem.Text = "Add Temporary Actor";
            frRem.ShowDialog();
        }

        private void AddToTableCommand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This places an object on furniture that is within the coordinates given.\nBe sure your coordinates are accurate!", "Before you continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PlaceOnTable frRem = new PlaceOnTable();
            frRem.Text = "Place Object on a Table.";
            frRem.ShowDialog();
        }

        private void AdvMoveCommand_Click(object sender, EventArgs e)
        {
            AdvancedMovement frRem = new AdvancedMovement();
            frRem.Text = "Advanced Movement";
            frRem.ShowDialog();
        }

        private void AmbientLightCommand_Click(object sender, EventArgs e)
        {
            ChangeAmbientLight frRem = new ChangeAmbientLight();
            frRem.Text = "Use Sliders to Set RGB";
            frRem.ShowDialog();
        }

        private void DelEventSel_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Remove(eventCommandList.SelectedItem);
        }

        private void EventClearAll_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Clear();
        }

        private void EventClone_Click(object sender, EventArgs e)
        {
            List<string> clone = new List<string>();
            foreach (var item in eventCommandList.SelectedItems)
            {
                string parse = item.ToString();
                clone.Add(parse);
            }
            File.WriteAllLines(Environment.CurrentDirectory + "\\Save Data\\templist.txt", clone);
            eventCommandList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\templist.txt"));
            File.Delete(Environment.CurrentDirectory + "\\Save Data\\templist.txt");
            
            
        }

        private void AnimateCommand_Click(object sender, EventArgs e)
        {
            Create_Animation frRem = new Create_Animation();
            frRem.Text = "Create Animation";
            frRem.ShowDialog();
        }

        private void AttatchChartoTempCommand_Click(object sender, EventArgs e)
        {
            AttachtoTemp frRem = new AttachtoTemp();
            frRem.Text = "Attach to Last Temp Sprite";
            frRem.ShowDialog();
        }

        private void ChangeLocationCommand_Click(object sender, EventArgs e)
        {
            ChangeLocation frRem = new ChangeLocation();
            frRem.Text = "Change Location";
            frRem.ShowDialog();
        }

        private void changePortraitCommand_Click(object sender, EventArgs e)
        {
            ChangeActorSprites frRem = new ChangeActorSprites();
            frRem.Text = "Changing Portraits and Sprites";
            frRem.ShowDialog();
        }

        private void EndEventCommand_Click(object sender, EventArgs e)
        {
            EndEvent frRem = new EndEvent();
            frRem.Text = "End Event";
            frRem.ShowDialog();
        }

        private void DoActionCommand_Click(object sender, EventArgs e)
        {
            Do_Action frRem = new Do_Action();
            frRem.Text = "Do Action";
            frRem.ShowDialog();
        }

        private void EmoteCommand_Click(object sender, EventArgs e)
        {
            Emote frRem = new Emote();
            frRem.Text = "Add Emote";
            frRem.ShowDialog();
        }

        private void FaceDirectionCommand_Click(object sender, EventArgs e)
        {
            FaceDirection frRem = new FaceDirection();
            frRem.Text = "Change NPC Facing";
            frRem.ShowDialog();
        }

        private void FadeCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("fade");
        }

        private void GlobalFadeCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("globalFade");

        }

        private void HaltCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("halt");

        }

        private void PauseCommand_Click(object sender, EventArgs e)
        {
            Pause_Event frRem = new Pause_Event();
            frRem.Text = "Pause Event Processing";
            frRem.ShowDialog();
        }

        private void JumpCommand_Click(object sender, EventArgs e)
        {
            JumpNPC frRem = new JumpNPC();
            frRem.Text = "Jump";
            frRem.ShowDialog();
        }

        private void MailCommand_Click(object sender, EventArgs e)
        {
            MailLetter frRem = new MailLetter();
            frRem.Text = "Mail";
            frRem.ShowDialog();
        }

        private void MessageCommand_Click(object sender, EventArgs e)
        {
            CreateMessage frRem = new CreateMessage();
            frRem.Text = "Create Message Box";
            frRem.ShowDialog();

        }

        private void MoveCommand_Click(object sender, EventArgs e)
        {
            MoveActor frRem = new MoveActor();
            frRem.Text = "Move NPC";
            frRem.ShowDialog();
        }

        private void ForkCommand_Click(object sender, EventArgs e)
        {
            EventFork frRem = new EventFork();
            frRem.Text = "Create Event Fork";
            frRem.ShowDialog();
        }

        private void PlayMusicCommand_Click(object sender, EventArgs e)
        {
            PlayMusic frRem = new PlayMusic();
            frRem.Text = "Play Song";
            frRem.ShowDialog();
        }

        private void PlaySoundCommand_Click(object sender, EventArgs e)
        {
            PlaySFX frRem = new PlaySFX();
            frRem.Text = "Play Sound Effect";
            frRem.ShowDialog();
        }

        private void PositionOffsetCommand_Click(object sender, EventArgs e)
        {
            PositionOffset frRem = new PositionOffset();
            frRem.Text = "Position Offset";
            frRem.ShowDialog();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void QuestionCommand_Click(object sender, EventArgs e)
        {
            Create_Question frRem = new Create_Question();
            frRem.Text = "Create a Question";
            frRem.ShowDialog();
        }

        private void SpeakCommand_Click(object sender, EventArgs e)
        {
            NPCSpeak frRem = new NPCSpeak();
            frRem.Text = "Create Speech";
            frRem.ShowDialog();
        }

        private void ViewportCommand_Click(object sender, EventArgs e)
        {
            ChangeViewport frRem = new ChangeViewport();
            frRem.Text = "Viewport";
            frRem.ShowDialog();
        }

        private void StopMusicCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("stopMusic");
        }

        private void TextAboveCommand_Click(object sender, EventArgs e)
        {
            TextAboveHead frRem = new TextAboveHead();
            frRem.Text = "Talk Bubble above NPC";
            frRem.ShowDialog();
        }

        private void WarpCommand_Click(object sender, EventArgs e)
        {
            WarpNPC frRem = new WarpNPC();
            frRem.Text = "Warp NPC";
            frRem.ShowDialog();
        }

        private void StopAniCommand_Click(object sender, EventArgs e)
        {
            StopAnimation frRem = new StopAnimation();
            frRem.Text = "Stop Animation";
            frRem.ShowDialog();
        }

        private void VPMoveCommand_Click(object sender, EventArgs e)
        {
            MoveViewport frRem = new MoveViewport();
            frRem.Text = "Move Viewport (Pan Screen)";
            frRem.ShowDialog();
        }

        private void JitterCommand_Click(object sender, EventArgs e)
        {
            JitterControl frRem = new JitterControl();
            frRem.Text = "Jitter Control";
            frRem.ShowDialog();
        }

        private void EatCommand_Click(object sender, EventArgs e)
        {
            FarmerEat frRem = new FarmerEat();
            frRem.Text = "Eat and Item";
            frRem.ShowDialog();
        }

        private void FriendshipCommand_Click(object sender, EventArgs e)
        {
            ModifyFP frRem = new ModifyFP();
            frRem.Text = "Modify Friendship Points";
            frRem.ShowDialog();
        }

        private void GlowCommand_Click(object sender, EventArgs e)
        {
            ScreenGlow frRem = new ScreenGlow();
            frRem.Text = "Screen Glow";
            frRem.ShowDialog();
        }

        private void StopGlowCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("stopGlowing");
        }

        private void ShowFrameCommand_Click(object sender, EventArgs e)
        {
            ShowFrame frRem = new ShowFrame();
            frRem.Text = "Show Frame";
            frRem.ShowDialog();
        }

        private void SwitchEventCommands_Click(object sender, EventArgs e)
        {
            SwitchEvent frRem = new SwitchEvent();
            frRem.Text = "Switch Event";
            frRem.ShowDialog();
        }

        private void ShakeCommand_Click(object sender, EventArgs e)
        {
            ShakeNPC frRem = new ShakeNPC();
            frRem.Text = "Shake NPC";
            frRem.ShowDialog();
        }

        private void RunningCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("setRunning");
        }

        private void ScreenFlashCommand_Click(object sender, EventArgs e)
        {
            ScreenFlash frRem = new ScreenFlash();
            frRem.Text = "Screen Flash";
            frRem.ShowDialog();
        }

        private void StopRunCommand_Click(object sender, EventArgs e)
        {
            eventCommandList.Items.Add("stopRunning");
        }

        private void Finished_Event_Click(object sender, EventArgs e)
        {
            if(mainEvent.Value != 0 && string.IsNullOrWhiteSpace(subEvent.Text))
            {
                //Create a full event
                //First compile all conditions
                foreach(var item in conditionsList.Items)
                {
                    string entry = item.ToString();
                    conditionCommands.Add(entry);
                }
                //now compile all commands
                foreach(var item in eventCommandList.Items)
                {
                    string entry = item.ToString();
                    eventCommandManifest.Add(entry);
                }
                //Assemble Conditions
                string conditionConstruct = $"{mainEvent.Value}/" + string.Join("/", conditionCommands);
                //Assemble Commands
                string eventConstruct = string.Join("/", eventCommandManifest);
                //Put them together
                Event_Studio mw = (Event_Studio)Application.OpenForms["Event_Studio"];
                mw.addEventtoList(conditionConstruct, eventConstruct);
                this.Close();

            }
            if(!string.IsNullOrWhiteSpace(subEvent.Text) && mainEvent.Value == 0)
            {
                //compile the commands
                foreach (var item in eventCommandList.Items)
                {
                    string entry = item.ToString();
                    eventCommandManifest.Add(entry);
                }
                //assemble
                string eventConstruct = string.Join("/", eventCommandManifest);
                string conditionConstruct = subEvent.Text;
                Event_Studio mw = (Event_Studio)Application.OpenForms["Event_Studio"];
                mw.addEventtoList(conditionConstruct, eventConstruct);
                this.Close();

            }
        }

        private void SpecificTempCommand_Click(object sender, EventArgs e)
        {
            specificTempSprite frRem = new specificTempSprite();
            frRem.Text = "Specific Temporary Sprite";
            frRem.ShowDialog();
        }
    }
}
