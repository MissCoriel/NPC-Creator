using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creator
{
    public partial class NPCDisposition : Form
    {
        public string systemName;
        string npcGender1;
        string npcGender2;
        string datable1;
        string datable2;
        public Dictionary<string, string> whenDatum = new Dictionary<string, string>();
        public string path;
        public string back;
        public bool dateChecker;
        public bool altDateChecker;
        public bool prSupport;
        public bool altDispoActive;
        public string mainPregnancy;
        public string saveAltMap;
        public string altPregnancy;
        public string saveGender;
        public static string passDate;
        public NPCDisposition()
        {
            InitializeComponent();

        }

        private void NPCDisposition_Load(object sender, EventArgs e)
        {
            
            systemName = Form1.exportSystem;
            groupBox1.Text = $"{systemName}'s Vital Stats";
            groupBox2.Text = $"{systemName}'s Home and Birthday";
            groupBox3.Text = $"{systemName}'s Love and Relations";
            npcDisplayName1.Text = "Display Name";
            path = $"Export/[CP]{systemName}/assets/disposition/Disposition.json";
            back = $"Export/[CP]{systemName}/assets/disposition/Disposition_backup.json";
            string[] populateLocations = File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\ValidLocations.txt");
            //MessageBox.Show($"NPC {systemName}", "Test");
            if(isFemale.Checked == false)
            {
                npcGender1 = "male";
            }
            if(isFemale.Checked == true)
            {
                npcGender1 = "female";
            }
            foreach (var location in populateLocations)
            {
                npcStartingMap1.Items.Add(location);
                altStartLocation.Items.Add(location);
            }
            if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Dispo.json"))
            {
                DispoModel model = JsonConvert.DeserializeObject<DispoModel>(File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Dispo.json"));
                this.PopulateDispo(model);
            }
            if(File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Conditions.json"))
            {
                string json = File.ReadAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Conditions.json");
                var recentLoad = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                foreach (KeyValuePair<string, string> pair in recentLoad)
                {
                    whenList.Items.Add($"{pair.Key}: {pair.Value}");
                }

            }
        }
        private DispoModel ReadForm()
        {
            string saveNPCAge = npcAge1.SelectedItem.ToString();
            string saveManners = npcManners1.SelectedItem.ToString();
            string saveSocial = npcSocial1.SelectedItem.ToString();
            string saveOptimism = npcOptimism1.SelectedItem.ToString();
            string saveOrigin = npcHome1.SelectedItem.ToString();
            string saveBDay = npcBdayMonth1.SelectedItem.ToString();

            if (isFemale.Checked)
            {
                saveGender = "female";

            }
            else
            {
                saveGender = "male";
            }
            if (isDatable.Checked)
            {
                dateChecker = true;
                NPCDisposition.passDate = "datable";
            }
            else
            {
                dateChecker = false;
                NPCDisposition.passDate = "not-datable";
            }
            string saveMapMain = npcStartingMap1.SelectedItem.ToString();
            if (isDatableAlt.Checked)
            {
                altDateChecker = true;
            }
            else
            {
                altDateChecker = false;
            }
            if (allowPregRole.Checked)
            {
                prSupport = true;
                mainPregnancy = npcPregnancyRole1.SelectedItem.ToString();

            }
            else
            {
                prSupport = false;
            }

            if (enableDispoAlt.Checked)
            {
                altDispoActive = true;
                saveAltMap = altStartLocation.SelectedItem.ToString();
                if (allowPregRole.Checked)
                {
                    altPregnancy = altPregRole.SelectedItem.ToString();

                }
            }
            else
            {
                altDispoActive = false;
            }

            if (enableDispoAlt.Checked && allowPregRole.Checked)
                return new DispoModel
                {
                    npcstrName = npcDisplayName1.Text,
                    npclovInt = npcLoveInt1.Text,
                    npcrelText = npcRelations1.Text,
                    npcCanDate = dateChecker,
                    lstAge = saveNPCAge,
                    lstGender = saveGender,
                    lstMapSpawn = saveMapMain,
                    lstPerMan = saveManners,
                    lstPerOpt = saveOptimism,
                    lstPerSoc = saveSocial,
                    lstBdaySeas = saveBDay,
                    lstOrigin = saveOrigin,
                    varMapX = (int)startX1.Value,
                    varMapY = (int)startY1.Value,
                    varBday = (int)npcBday1.Value,
                    pregRoleFlag = prSupport,
                    npcPregRolesave = mainPregnancy,
                    enabledAltDispo = altDispoActive,
                    altNPCName = altDisplayName.Text,
                    altMaparea = saveAltMap,
                    altCanDate = altDateChecker,
                    altPregRole = altPregnancy,
                    varAltMapX = (int)altMapX.Value,
                    varAltMapY = (int)altMapY.Value,

                };
            else if (enableDispoAlt.Checked && !allowPregRole.Checked)
                return new DispoModel
                {
                    npcstrName = npcDisplayName1.Text,
                    npclovInt = npcLoveInt1.Text,
                    npcrelText = npcRelations1.Text,
                    npcCanDate = dateChecker,
                    lstAge = saveNPCAge,
                    lstGender = saveGender,
                    lstMapSpawn = saveMapMain,
                    lstPerMan = saveManners,
                    lstPerOpt = saveOptimism,
                    lstPerSoc = saveSocial,
                    lstBdaySeas = saveBDay,
                    lstOrigin = saveOrigin,
                    varMapX = (int)startX1.Value,
                    varMapY = (int)startY1.Value,
                    varBday = (int)npcBday1.Value,
                    pregRoleFlag = prSupport,
                    enabledAltDispo = altDispoActive,
                    altNPCName = altDisplayName.Text,
                    altMaparea = saveAltMap,
                    altCanDate = altDateChecker,
                    varAltMapX = (int)altMapX.Value,
                    varAltMapY = (int)altMapY.Value,

                };
            else if (allowPregRole.Checked && !enableDispoAlt.Checked)
                return new DispoModel
                {
                    npcstrName = npcDisplayName1.Text,
                    npclovInt = npcLoveInt1.Text,
                    npcrelText = npcRelations1.Text,
                    npcCanDate = dateChecker,
                    lstAge = saveNPCAge,
                    lstGender = saveGender,
                    lstMapSpawn = saveMapMain,
                    lstPerMan = saveManners,
                    lstPerOpt = saveOptimism,
                    lstPerSoc = saveSocial,
                    lstBdaySeas = saveBDay,
                    lstOrigin = saveOrigin,
                    varMapX = (int)startX1.Value,
                    varMapY = (int)startY1.Value,
                    varBday = (int)npcBday1.Value,
                    pregRoleFlag = prSupport,
                    npcPregRolesave = mainPregnancy,
                    enabledAltDispo = altDispoActive,

                };
            else if (!allowPregRole.Checked && !enableDispoAlt.Checked)
                return new DispoModel
                {
                    npcstrName = npcDisplayName1.Text,
                    npclovInt = npcLoveInt1.Text,
                    npcrelText = npcRelations1.Text,
                    npcCanDate = dateChecker,
                    lstAge = saveNPCAge,
                    lstGender = saveGender,
                    lstMapSpawn = saveMapMain,
                    lstPerMan = saveManners,
                    lstPerOpt = saveOptimism,
                    lstPerSoc = saveSocial,
                    lstBdaySeas = saveBDay,
                    lstOrigin = saveOrigin,
                    varMapX = (int)startX1.Value,
                    varMapY = (int)startY1.Value,
                    varBday = (int)npcBday1.Value,
                    pregRoleFlag = prSupport,
                    enabledAltDispo = altDispoActive,
                };
            else throw new Exception("If you're reading this.. it didn't ReadForm Right");
        }
        private void PopulateDispo(DispoModel model)
        {
            this.npcDisplayName1.Text = model.npcstrName;
            this.npcRelations1.Text = model.npcrelText;
            this.npcLoveInt1.Text = model.npclovInt;
            this.startX1.Value = model.varMapX;
            this.startY1.Value = model.varMapY;
            this.npcBday1.Value = model.varBday;
            if (model.npcCanDate == true)
            {
                isDatable.Checked = true;
            }
            else if (model.npcCanDate == false)
            {
                isDatable.Checked = false;
            }
            if (model.altCanDate == true)
            {
                isDatableAlt.Checked = true;
            }
            else if (model.altCanDate == false)
            {
                isDatableAlt.Checked = false;
            }
            if (model.lstGender == "female")
            {
                isFemale.Checked = true;
            }
            else
            {
                isFemale.Checked = false;
            }
            npcAge1.SelectedItem = model.lstAge;
            npcStartingMap1.SelectedItem = model.lstMapSpawn;
            npcManners1.SelectedItem = model.lstPerMan;
            npcSocial1.SelectedItem = model.lstPerSoc;
            npcOptimism1.SelectedItem = model.lstPerOpt;
            npcBdayMonth1.SelectedItem = model.lstBdaySeas;
            npcHome1.SelectedItem = model.lstOrigin;
            if (model.pregRoleFlag == true)
            {
                allowPregRole.Checked = true;
                npcPregnancyRole1.SelectedItem = model.npcPregRolesave;
                if (model.enabledAltDispo == true)
                {
                    altPregRole.SelectedItem = model.altPregRole;
                }
            }
            else
            {
                allowPregRole.Checked = false;
            }

            if (model.enabledAltDispo == true)
            {
                enableDispoAlt.Checked = true;
                this.altDisplayName.Text = model.altNPCName;
                altStartLocation.SelectedItem = model.altMaparea;
                this.altMapX.Value = model.varAltMapX;
                this.altMapY.Value = model.varAltMapY;
            }
        }

        private void allowPregRole_CheckedChanged(object sender, EventArgs e)
        {
            if (allowPregRole.Checked == true)
            {
                npcPregnancyRole1.Enabled = true;
                altPregRole.Enabled = true;
            }
            else
            {
                npcPregnancyRole1.Enabled = false;
                altPregRole.Enabled = false;
            }
        }

        private void isFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(isFemale.Checked == true)
            {
                npcGender1 = "female";
            }
            else
            {
                npcGender1 = "male";
            }
        }

        private void isDatable_CheckedChanged(object sender, EventArgs e)
        {
            if (isDatable.Checked == true)
            {
                datable1 = "datable";
                Form1.dateCheck = "datable";
            }
            else
            {
                datable1 = "non-datable";
                Form1.dateCheck = "non-datable";
            }
        }

        private void enableDispoAlt_CheckedChanged(object sender, EventArgs e)
        {
            if(enableDispoAlt.Checked == true)
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void isDatableAlt_CheckedChanged(object sender, EventArgs e)
        {
            if (isDatableAlt.Checked == true)
            {
                datable2 = "datable";
                Form1.dateCheck = "datable";

            }
            else
            {
                datable2 = "non-datable";
                Form1.dateCheck = "non-datable";

            }

        }

        private void addWhen_Click(object sender, EventArgs e)
        {
            whenList.Items.Add(whenData.Text);
        }

        private void delSelect_Click(object sender, EventArgs e)
        {
            whenList.Items.Remove(whenList.SelectedItem);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            whenList.Items.Clear();
        }

        private void processDispo_Click(object sender, EventArgs e)
        {
            if (npcAge1.Text == "child" && isDatable.Checked)
            {
                MessageBox.Show("A child cannot be married!", "Why don't you take a seat over there?!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (npcAge1.Text == "child" && isDatableAlt.Checked)
            {
                MessageBox.Show("A child cannot be married!", "Why don't you take a seat over there?!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (isDatable.Checked == true)
                {
                    datable1 = "datable";
                    Form1.dateCheck = "datable";
                    if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canNotDat.date"))
                    {
                        File.Delete(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canNotDat.date");
                    }
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date", "");

                }
                else
                {
                    datable1 = "non-datable";
                    Form1.dateCheck = "non-datable";
                    if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date"))
                    {
                        File.Delete(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date");
                    }
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canNotDat.date", "");
                }
                if (isDatableAlt.Checked == true)
                {
                    datable2 = "datable";
                    Form1.dateCheck = "datable";
                    if (File.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canNotDat.date"))
                    {
                        File.Delete(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canNotDat.date");
                    }
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\canDate.date", "");

                }


                if (!System.IO.Directory.Exists(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData"))
                {
                    System.IO.Directory.CreateDirectory($"Save Data/{systemName}_saveData");
                }

                if (npcAge1.SelectedItem == null || npcBdayMonth1 == null || npcDisplayName1 == null || npcHome1.SelectedItem == null || npcManners1.SelectedItem == null || npcOptimism1.SelectedItem == null || npcSocial1.SelectedItem == null || npcStartingMap1.SelectedItem == null)
                {
                    MessageBox.Show("You have not selected everything you needed!\nVerify all options!", "Incomplete Disposition", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Save Datum
                    DispoModel dispositionSaveData = this.ReadForm();
                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Dispo.json", JsonConvert.SerializeObject(dispositionSaveData, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                    if (enableDispoAlt.Checked == true) //Adds an alternate Dispo with When Conditions given
                    {
                        if (allowPregRole.Checked == true)//Pregnancy Role
                        {
                            if (npcPregnancyRole1.SelectedItem == null || altPregRole == null)
                            {
                                MessageBox.Show("You are missing data for Pregnancy Role.\nVerify information.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //Process Main Dispo
                                PatchVariable mainDispoPreg = new PatchVariable
                                {
                                    Action = "EditData",
                                    Target = "data/NPCDispositions",
                                    Entries = new Dictionary<string, string>
                                    {
                                        [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable1}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text} {npcPregnancyRole1.SelectedItem}/{npcStartingMap1.SelectedItem} {startX1.Value} {startY1.Value}/{npcDisplayName1.Text}",
                                    }

                                };
                                //process When conditions
                                foreach (var item in whenList.Items)
                                {
                                    string entry = item.ToString();
                                    string key = entry.Substring(0, entry.LastIndexOf(':'));
                                    string value = entry.Substring(entry.LastIndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                                    try
                                    {
                                        whenDatum.Add(key, value);
                                        // MessageBox.Show($"{key}, {value}", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    File.WriteAllText(Environment.CurrentDirectory + $"\\Save Data\\{systemName}_saveData\\Conditions.json", JsonConvert.SerializeObject(whenDatum, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                                }
                                //process Alternate Dispo
                                PatchVariable altDispoPreg = new PatchVariable
                                {
                                    Action = "EditData",
                                    Target = "data/NPCDispositions",
                                    When = whenDatum,
                                    Entries = new Dictionary<string, string>
                                    {
                                        [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable2}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text} {altPregRole.SelectedItem}/{altStartLocation.SelectedItem} {altMapX.Value} {altMapY.Value}/{altDisplayName.Text}",

                                    }
                                };
                                //Create JSON
                                ContentVariable dispositionFilepreg = new ContentVariable
                                {
                                    Changes = new PatchVariable[] { mainDispoPreg, altDispoPreg }
                                };
                                if (!Directory.Exists($"Export/[CP]{systemName}/assets/disposition"))
                                {
                                    Directory.CreateDirectory($"Export/[CP]{systemName}/assets/disposition");//Update Legacy NPCs
                                }
                                File.WriteAllText(path, JsonConvert.SerializeObject(dispositionFilepreg, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                                File.WriteAllText(back, JsonConvert.SerializeObject(dispositionFilepreg, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                                MessageBox.Show("Disposition File Created!", "Disposition File Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();



                            }
                        }
                        else //No Pregnancy Role
                        {
                            //Process Main Dispo
                            PatchVariable mainDispo2 = new PatchVariable
                            {
                                Action = "EditData",
                                Target = "data/NPCDispositions",
                                Entries = new Dictionary<string, string>
                                {
                                    [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable1}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text}/{npcStartingMap1.SelectedItem} {startX1.Value} {startY1.Value}/{npcDisplayName1.Text}",
                                }

                            };
                            //process When conditions
                            foreach (var item in whenList.Items)
                            {
                                string entry = item.ToString();
                                string key = entry.Substring(0, entry.LastIndexOf(':'));
                                string value = entry.Substring(entry.LastIndexOf(':') + 2); // +1 to get past :, and +1 to get past the space
                                try
                                {
                                    whenDatum.Add(key, value);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            //process Alternate Dispo
                            PatchVariable altDispo2 = new PatchVariable
                            {
                                Action = "EditData",
                                Target = "data/NPCDispositions",
                                When = whenDatum,
                                Entries = new Dictionary<string, string>
                                {
                                    [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable2}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text}/{altStartLocation.SelectedItem} {altMapX.Value} {altMapY.Value}/{altDisplayName.Text}",

                                }
                            };
                            //Create JSON
                            ContentVariable dispositionFile2 = new ContentVariable
                            {
                                Changes = new PatchVariable[] { mainDispo2, altDispo2 }
                            };
                            if (!Directory.Exists($"Export/[CP]{systemName}/assets/disposition"))
                            {
                                Directory.CreateDirectory($"Export/[CP]{systemName}/assets/disposition");//Update Legacy NPCs
                            }
                            File.WriteAllText(path, JsonConvert.SerializeObject(dispositionFile2, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            File.WriteAllText(back, JsonConvert.SerializeObject(dispositionFile2, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            MessageBox.Show("Disposition File Created!", "Disposition File Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }


                    }
                    else
                    {
                        if (allowPregRole.Checked == true)
                        {
                            //Process Main Dispo
                            PatchVariable mainDispoPreg = new PatchVariable
                            {
                                Action = "EditData",
                                Target = "data/NPCDispositions",
                                Entries = new Dictionary<string, string>
                                {
                                    [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable1}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text} {npcPregnancyRole1.SelectedItem}/{npcStartingMap1.SelectedItem} {startX1.Value} {startY1.Value}/{npcDisplayName1.Text}",
                                }

                            };
                            //Create File
                            //Create JSON
                            ContentVariable dispositionFilepreg = new ContentVariable
                            {
                                Changes = new PatchVariable[] { mainDispoPreg }
                            };
                            if (!Directory.Exists($"Export/[CP]{systemName}/assets/disposition"))
                            {
                                Directory.CreateDirectory($"Export/[CP]{systemName}/assets/disposition");//Update Legacy NPCs
                            }
                            File.WriteAllText(path, JsonConvert.SerializeObject(dispositionFilepreg, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            File.WriteAllText(back, JsonConvert.SerializeObject(dispositionFilepreg, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            MessageBox.Show("Disposition File Created!", "Disposition File Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            //Process Main Dispo
                            PatchVariable mainDispo = new PatchVariable
                            {
                                Action = "EditData",
                                Target = "data/NPCDispositions",
                                Entries = new Dictionary<string, string>
                                {
                                    [$"{systemName}"] = $"{npcAge1.SelectedItem}/{npcManners1.SelectedItem}/{npcSocial1.SelectedItem}/{npcOptimism1.SelectedItem}/{npcGender1}/{datable1}/{npcLoveInt1.Text}/{npcHome1.SelectedItem}/{npcBdayMonth1.SelectedItem} {npcBday1.Value}/{npcRelations1.Text}/{npcStartingMap1.SelectedItem} {startX1.Value} {startY1.Value}/{npcDisplayName1.Text}",
                                }

                            };
                            //Create File
                            //Create JSON
                            ContentVariable dispositionFile = new ContentVariable
                            {
                                Changes = new PatchVariable[] { mainDispo }
                            };
                            if (!Directory.Exists($"Export/[CP]{systemName}/assets/disposition"))
                            {
                                Directory.CreateDirectory($"Export/[CP]{systemName}/assets/disposition");//Update Legacy NPCs
                            }
                            File.WriteAllText(path, JsonConvert.SerializeObject(dispositionFile, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            File.WriteAllText(back, JsonConvert.SerializeObject(dispositionFile, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
                            MessageBox.Show("Disposition File Created!", "Disposition File Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

                }
            }
           
        }
    }
}
