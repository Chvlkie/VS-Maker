﻿using VSMaker.Data;

namespace VSMaker.Forms
{
    public partial class LoadingDialog : Form
    {
        private Mainform mainform;
        private LoadingDataEnum loadType;

        public LoadingDialog(Mainform mainform, LoadingDataEnum loadType)
        {
            this.mainform = mainform;
            this.loadType = loadType;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            progressBar1.Value = 0;
            switch (loadType)
            {
                case LoadingDataEnum.UnpackRom:
                    Text = "Unpacking ROM Data";
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    UnpackRom();
                    break;

                case LoadingDataEnum.LoadRomData:
                    Text = "Loading ROM Data";
                    progressBar1.Maximum = 100;
                    LoadRomData();
                    break;

                case LoadingDataEnum.UnpackNarcs:
                    Text = "Unpacking Essential NARCs";
                    progressBar1.Maximum = 100;
                    UnpackNarcs();
                    break;

                case LoadingDataEnum.SetupEditor:
                    Text = "Setting Up Editor";
                    progressBar1.Maximum = 100;
                    SetupEditor();
                    break;

                case LoadingDataEnum.SaveRom:
                    Text = "Saving ROM";
                    progressBar1.Maximum = 100;
                    SaveRom();
                    break;

                case LoadingDataEnum.ExportTextTable:
                    Text = "Exporting Excel Sheet";
                    progressBar1.Maximum = mainform.trainerTableCount + 10;
                    ExportExcel();
                    break;

                case LoadingDataEnum.ImportTextTable:
                    Text = "Importing Excel Sheet";
                    progressBar1.Maximum = mainform.trainerTableImportCount + 10;
                    ImportExcel();
                    break;

                case LoadingDataEnum.SaveTrainerTextTable:
                    Text = "Saving Trainer Text Table";
                    progressBar1.Maximum = mainform.trainerTableCount + 10;
                    SaveTrainerTextTable();
                    break;

                case LoadingDataEnum.RepointTextTable:
                    Text = "Sorting & Repointing Trainer Text Table";
                    progressBar1.Maximum = mainform.trainerTableCount + 10;
                    RepointTrainerTable();
                    break;

                default:
                    FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
                    Close();
                    break;
            }
        }

        public async Task UnpackRom()
        {
            await Task.Delay(500);
            await Task.Run(() => mainform.BeginUnpackRomData());
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 100;
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task LoadRomData()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginLoadRomData(progress));
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task UnpackNarcs()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginUnpackNarcs(progress));
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task SetupEditor()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginSetupEditor(progress));
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task SaveRom()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginSaveRomChanges(progress));
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task ExportExcel()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginExportExcel(progress, progressBar1.Maximum));
            progressBar1.Value = progressBar1.Maximum;
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task ImportExcel()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginImportExcel(progress, progressBar1.Maximum));
            progressBar1.Value = progressBar1.Maximum; 
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task RepointTrainerTable()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginSortRepointTrainerText(progress, progressBar1.Maximum));
            progressBar1.Value = progressBar1.Maximum;
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        public async Task SaveTrainerTextTable()
        {
            await Task.Delay(500);
            var progress = new Progress<int>(value => { progressBar1.Value = value; });
            await Task.Run(() => mainform.BeginSaveTrainerTextTable(progress));
            FormClosing -= new FormClosingEventHandler(LoadingDialog_FormClosing);
            Close();
        }

        private void LoadingDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}