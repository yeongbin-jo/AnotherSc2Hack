﻿using AnotherSc2Hack.Classes.FrontEnds.Custom_Controls;
using Utilities.Events;

namespace AnotherSc2Hack.Classes.FrontEnds.MainHandler
{
    partial class NewMainHandler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainHandler));
            this.pnlLeftSelection = new System.Windows.Forms.Panel();
            this.pnlVarious = new System.Windows.Forms.Panel();
            this.tlpVariousContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVariousAlertContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVariousWorkerCoachContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpVariousPersonalApmContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHelpMe = new System.Windows.Forms.Panel();
            this.pnlBenchmark = new System.Windows.Forms.Panel();
            this.tlpBenchmarkDataContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBenchmarkDrawingContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCredits = new System.Windows.Forms.Panel();
            this.pbMainProgress = new System.Windows.Forms.ProgressBar();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.txtDebugUnitMemory = new System.Windows.Forms.TextBox();
            this.txtDebugUnitname = new System.Windows.Forms.TextBox();
            this.txtDebugPlayerMemory = new System.Windows.Forms.TextBox();
            this.txtDebugPlayername = new System.Windows.Forms.TextBox();
            this.pnlApplication = new System.Windows.Forms.Panel();
            this.wbNews = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chBxLanguage = new System.Windows.Forms.ComboBox();
            this.pnlOverlays = new System.Windows.Forms.Panel();
            this.pnlPanelContainer = new System.Windows.Forms.Panel();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.pcbPluginsImages = new System.Windows.Forms.PictureBox();
            this.rtbPluginsDescription = new System.Windows.Forms.RichTextBox();
            this.cmPluginInstall = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsPluginInstallPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPluginRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsPluginRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainArea = new System.Windows.Forms.Panel();
            this.pnlBottomStrip = new System.Windows.Forms.Panel();
            this.btnLaunchResource = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchProduction = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchIncome = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchUnit = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchWorker = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchArmy = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchMaphack = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnLaunchApm = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblTabname = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnAdjustPanels = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.aChBxShowWebContent = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.lblApplicationGlobalSettings = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblApplicationMemoryReading = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblApplicationGraphicsRefresh = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtMemoryRefresh = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lblApplicationLanguage = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtGraphicsRefresh = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.aChBxOnlyDrawInForeground = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.lblApplicationReposition = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnReposition = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.ktxtReposition = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.KeyTextBox();
            this.btnRestoreSettings = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnPluginsInstallPlugin = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblPluginsImageposition = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnPluginsImagesNext = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnPluginsImagesPrevious = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblPluginImages = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblPluginDescription = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lstvPluginsAvailablePlugins = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chPluginsAvailablePluginName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPluginsAvailablePluginVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPluginAvailablePlugins = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lstvPluginsLoadedPlugins = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chPluginsLoadedPluginName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPluginsLoadedPluginVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPluginLoadedPlugins = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lstvDebugMatchdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chDebugMatchDataAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDebugMatchDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDebugMatchdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lstvDebugMapdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chDebugMapDataAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDebugMapDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDebugMapdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtDebugUnitLocation = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtDebugPlayerLocation = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lstvDebugUnitdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chDebugUnitDataAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDebugUnitDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvDebugPlayderdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chDebugPlayerDataAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDebugPlayerDataValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDebugUnitObjects = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblDebugUnitLocation = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblDebugUnitname = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnDebugUnitForward = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnDebugUnitBack = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblDebugUnitdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblDebugPlayerObjects = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblDebugPlayerLocation = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblDebugPlayername = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnDebugPlayerForward = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnDebugPlayerBack = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblDebugPlayerdata = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.pnlOverlayArmy = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayBasics();
            this.pnlOverlayApm = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayBasics();
            this.pnlOverlayIncome = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayBasics();
            this.pnlOverlayResource = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayBasics();
            this.cpnlOverlaysProduction = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysUnits = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysMaphack = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysApm = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysArmy = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysWorker = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysIncome = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlaysResources = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.pnlOverlayProductiontab = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayProductiontab();
            this.pnlOverlayUnittab = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayUnittab();
            this.pnlOverlayMaphack = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayMaphack();
            this.pnlOverlayWorker = new AnotherSc2Hack.Classes.FrontEnds.Container.PanelOverlayWorker();
            this.btnVariousOpenAlerts = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblVariousShowAlert = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtVariousAlertShowDuration = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.aChBxVariousAlertSoundNotification = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.aChBxVariousShowAlerts = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.lblVariousDisableAfter = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtVariousWorkerCoachDisableAfter = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.aChBxVariousPersonalApmAlert = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.ntxtVariousApmLimit = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lblVariousPersonalApm = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.aChBxVariousShowPersonalApm = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.aChBxVariousWorkerCoach = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.lblVariousWorkerCoach = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblVariousPersonalClock = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.aChBxVariousShowPersonalClock = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox();
            this.lblVariousAlerts = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnHelpMeCopyEmail = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnHelpMeCopyBitcoin = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblHelpMeBitcoin = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnHelpMePaypal = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblHelpCash = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnHelpMeLocalize = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnHelpMeGithubIssues = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblHelpLocalize = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblHelpMeEmail = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.btnHelpMeEmailMe = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.btnHelpMePostOnD3scene = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageButton();
            this.lblHelpSuggestionsBug = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkData = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkDataInterval = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtBenchmarkDataIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lblBenchmarkDataIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtBenchmarkDataInterval = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lblBenchmarkResourceIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkMaphackIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkArmyIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkProductiontabIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkUnittabIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkApmIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkWorkerIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkIncomeIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lblBenchmarkDrawingInterval = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.ntxtBenchmarkMaphackIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkProductionTabIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkUnitTabIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkApmIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkArmyIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkWorkerIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkIncomeIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkResourceIterations = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.ntxtBenchmarkDrawingInterval = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.NumberTextBox();
            this.lblBenchmarkDrawing = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.LanguageLabel();
            this.lstvCredits = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherListview();
            this.chCreditsContributer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreditsReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpnlVarious = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlHelpMe = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlBenchmark = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlCredits = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlDebug = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlApplication = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlOverlays = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.cpnlPlugins = new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ClickablePanel();
            this.pnlLeftSelection.SuspendLayout();
            this.pnlVarious.SuspendLayout();
            this.tlpVariousContainer.SuspendLayout();
            this.tlpVariousAlertContainer.SuspendLayout();
            this.tlpVariousWorkerCoachContainer.SuspendLayout();
            this.tlpVariousPersonalApmContainer.SuspendLayout();
            this.pnlHelpMe.SuspendLayout();
            this.pnlBenchmark.SuspendLayout();
            this.tlpBenchmarkDataContainer.SuspendLayout();
            this.tlpBenchmarkDrawingContainer.SuspendLayout();
            this.pnlCredits.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.pnlApplication.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlOverlays.SuspendLayout();
            this.pnlPanelContainer.SuspendLayout();
            this.pnlPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPluginsImages)).BeginInit();
            this.cmPluginInstall.SuspendLayout();
            this.cmPluginRemove.SuspendLayout();
            this.pnlMainArea.SuspendLayout();
            this.pnlBottomStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftSelection
            // 
            this.pnlLeftSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeftSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.pnlLeftSelection.Controls.Add(this.cpnlVarious);
            this.pnlLeftSelection.Controls.Add(this.cpnlHelpMe);
            this.pnlLeftSelection.Controls.Add(this.cpnlBenchmark);
            this.pnlLeftSelection.Controls.Add(this.cpnlCredits);
            this.pnlLeftSelection.Controls.Add(this.pbMainProgress);
            this.pnlLeftSelection.Controls.Add(this.cpnlDebug);
            this.pnlLeftSelection.Controls.Add(this.cpnlApplication);
            this.pnlLeftSelection.Controls.Add(this.cpnlOverlays);
            this.pnlLeftSelection.Controls.Add(this.cpnlPlugins);
            this.pnlLeftSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSelection.Name = "pnlLeftSelection";
            this.pnlLeftSelection.Size = new System.Drawing.Size(152, 593);
            this.pnlLeftSelection.TabIndex = 5;
            // 
            // pnlVarious
            // 
            this.pnlVarious.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVarious.Controls.Add(this.tlpVariousContainer);
            this.pnlVarious.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVarious.Location = new System.Drawing.Point(0, 80);
            this.pnlVarious.Name = "pnlVarious";
            this.pnlVarious.Padding = new System.Windows.Forms.Padding(15);
            this.pnlVarious.Size = new System.Drawing.Size(1029, 450);
            this.pnlVarious.TabIndex = 32;
            // 
            // tlpVariousContainer
            // 
            this.tlpVariousContainer.AutoSize = true;
            this.tlpVariousContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVariousContainer.ColumnCount = 2;
            this.tlpVariousContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousContainer.Controls.Add(this.btnVariousOpenAlerts, 1, 12);
            this.tlpVariousContainer.Controls.Add(this.tlpVariousAlertContainer, 0, 14);
            this.tlpVariousContainer.Controls.Add(this.aChBxVariousAlertSoundNotification, 0, 13);
            this.tlpVariousContainer.Controls.Add(this.aChBxVariousShowAlerts, 0, 12);
            this.tlpVariousContainer.Controls.Add(this.tlpVariousWorkerCoachContainer, 0, 9);
            this.tlpVariousContainer.Controls.Add(this.tlpVariousPersonalApmContainer, 0, 2);
            this.tlpVariousContainer.Controls.Add(this.lblVariousPersonalApm, 0, 0);
            this.tlpVariousContainer.Controls.Add(this.aChBxVariousShowPersonalApm, 0, 1);
            this.tlpVariousContainer.Controls.Add(this.aChBxVariousWorkerCoach, 0, 8);
            this.tlpVariousContainer.Controls.Add(this.lblVariousWorkerCoach, 0, 7);
            this.tlpVariousContainer.Controls.Add(this.lblVariousPersonalClock, 0, 4);
            this.tlpVariousContainer.Controls.Add(this.aChBxVariousShowPersonalClock, 0, 5);
            this.tlpVariousContainer.Controls.Add(this.lblVariousAlerts, 0, 11);
            this.tlpVariousContainer.Location = new System.Drawing.Point(15, 15);
            this.tlpVariousContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVariousContainer.Name = "tlpVariousContainer";
            this.tlpVariousContainer.RowCount = 15;
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVariousContainer.Size = new System.Drawing.Size(231, 424);
            this.tlpVariousContainer.TabIndex = 21;
            // 
            // tlpVariousAlertContainer
            // 
            this.tlpVariousAlertContainer.AutoSize = true;
            this.tlpVariousAlertContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVariousAlertContainer.ColumnCount = 2;
            this.tlpVariousAlertContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousAlertContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousAlertContainer.Controls.Add(this.lblVariousShowAlert, 0, 0);
            this.tlpVariousAlertContainer.Controls.Add(this.ntxtVariousAlertShowDuration, 1, 0);
            this.tlpVariousAlertContainer.Location = new System.Drawing.Point(0, 394);
            this.tlpVariousAlertContainer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpVariousAlertContainer.Name = "tlpVariousAlertContainer";
            this.tlpVariousAlertContainer.RowCount = 1;
            this.tlpVariousAlertContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVariousAlertContainer.Size = new System.Drawing.Size(166, 27);
            this.tlpVariousAlertContainer.TabIndex = 24;
            // 
            // tlpVariousWorkerCoachContainer
            // 
            this.tlpVariousWorkerCoachContainer.AutoSize = true;
            this.tlpVariousWorkerCoachContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVariousWorkerCoachContainer.ColumnCount = 2;
            this.tlpVariousWorkerCoachContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousWorkerCoachContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousWorkerCoachContainer.Controls.Add(this.lblVariousDisableAfter, 0, 0);
            this.tlpVariousWorkerCoachContainer.Controls.Add(this.ntxtVariousWorkerCoachDisableAfter, 1, 0);
            this.tlpVariousWorkerCoachContainer.Location = new System.Drawing.Point(0, 247);
            this.tlpVariousWorkerCoachContainer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tlpVariousWorkerCoachContainer.Name = "tlpVariousWorkerCoachContainer";
            this.tlpVariousWorkerCoachContainer.RowCount = 1;
            this.tlpVariousWorkerCoachContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVariousWorkerCoachContainer.Size = new System.Drawing.Size(180, 27);
            this.tlpVariousWorkerCoachContainer.TabIndex = 23;
            // 
            // tlpVariousPersonalApmContainer
            // 
            this.tlpVariousPersonalApmContainer.AutoSize = true;
            this.tlpVariousPersonalApmContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVariousPersonalApmContainer.ColumnCount = 2;
            this.tlpVariousPersonalApmContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousPersonalApmContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVariousPersonalApmContainer.Controls.Add(this.aChBxVariousPersonalApmAlert, 0, 0);
            this.tlpVariousPersonalApmContainer.Controls.Add(this.ntxtVariousApmLimit, 1, 0);
            this.tlpVariousPersonalApmContainer.Location = new System.Drawing.Point(3, 59);
            this.tlpVariousPersonalApmContainer.Name = "tlpVariousPersonalApmContainer";
            this.tlpVariousPersonalApmContainer.RowCount = 1;
            this.tlpVariousPersonalApmContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVariousPersonalApmContainer.Size = new System.Drawing.Size(156, 30);
            this.tlpVariousPersonalApmContainer.TabIndex = 22;
            // 
            // pnlHelpMe
            // 
            this.pnlHelpMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHelpMe.Controls.Add(this.btnHelpMeCopyEmail);
            this.pnlHelpMe.Controls.Add(this.btnHelpMeCopyBitcoin);
            this.pnlHelpMe.Controls.Add(this.lblHelpMeBitcoin);
            this.pnlHelpMe.Controls.Add(this.btnHelpMePaypal);
            this.pnlHelpMe.Controls.Add(this.lblHelpCash);
            this.pnlHelpMe.Controls.Add(this.btnHelpMeLocalize);
            this.pnlHelpMe.Controls.Add(this.btnHelpMeGithubIssues);
            this.pnlHelpMe.Controls.Add(this.lblHelpLocalize);
            this.pnlHelpMe.Controls.Add(this.lblHelpMeEmail);
            this.pnlHelpMe.Controls.Add(this.btnHelpMeEmailMe);
            this.pnlHelpMe.Controls.Add(this.btnHelpMePostOnD3scene);
            this.pnlHelpMe.Controls.Add(this.lblHelpSuggestionsBug);
            this.pnlHelpMe.Location = new System.Drawing.Point(0, 80);
            this.pnlHelpMe.Name = "pnlHelpMe";
            this.pnlHelpMe.Size = new System.Drawing.Size(1029, 450);
            this.pnlHelpMe.TabIndex = 14;
            // 
            // pnlBenchmark
            // 
            this.pnlBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBenchmark.Controls.Add(this.tlpBenchmarkDataContainer);
            this.pnlBenchmark.Controls.Add(this.tlpBenchmarkDrawingContainer);
            this.pnlBenchmark.Location = new System.Drawing.Point(0, 80);
            this.pnlBenchmark.Name = "pnlBenchmark";
            this.pnlBenchmark.Padding = new System.Windows.Forms.Padding(15);
            this.pnlBenchmark.Size = new System.Drawing.Size(1029, 450);
            this.pnlBenchmark.TabIndex = 25;
            // 
            // tlpBenchmarkDataContainer
            // 
            this.tlpBenchmarkDataContainer.AutoSize = true;
            this.tlpBenchmarkDataContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBenchmarkDataContainer.ColumnCount = 2;
            this.tlpBenchmarkDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.53672F));
            this.tlpBenchmarkDataContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.46328F));
            this.tlpBenchmarkDataContainer.Controls.Add(this.lblBenchmarkData, 0, 0);
            this.tlpBenchmarkDataContainer.Controls.Add(this.lblBenchmarkDataInterval, 0, 1);
            this.tlpBenchmarkDataContainer.Controls.Add(this.ntxtBenchmarkDataIterations, 1, 2);
            this.tlpBenchmarkDataContainer.Controls.Add(this.lblBenchmarkDataIterations, 0, 2);
            this.tlpBenchmarkDataContainer.Controls.Add(this.ntxtBenchmarkDataInterval, 1, 1);
            this.tlpBenchmarkDataContainer.Location = new System.Drawing.Point(15, 15);
            this.tlpBenchmarkDataContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBenchmarkDataContainer.Name = "tlpBenchmarkDataContainer";
            this.tlpBenchmarkDataContainer.RowCount = 3;
            this.tlpBenchmarkDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDataContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDataContainer.Size = new System.Drawing.Size(177, 86);
            this.tlpBenchmarkDataContainer.TabIndex = 37;
            // 
            // tlpBenchmarkDrawingContainer
            // 
            this.tlpBenchmarkDrawingContainer.AutoSize = true;
            this.tlpBenchmarkDrawingContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBenchmarkDrawingContainer.ColumnCount = 2;
            this.tlpBenchmarkDrawingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.05756F));
            this.tlpBenchmarkDrawingContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.94245F));
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkResourceIterations, 0, 2);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkMaphackIterations, 0, 9);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkArmyIterations, 0, 5);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkProductiontabIterations, 0, 8);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkUnittabIterations, 0, 7);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkApmIterations, 0, 6);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkWorkerIterations, 0, 4);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkIncomeIterations, 0, 3);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkDrawingInterval, 0, 1);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkMaphackIterations, 1, 9);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkProductionTabIterations, 1, 8);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkUnitTabIterations, 1, 7);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkApmIterations, 1, 6);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkArmyIterations, 1, 5);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkWorkerIterations, 1, 4);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkIncomeIterations, 1, 3);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkResourceIterations, 1, 2);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.ntxtBenchmarkDrawingInterval, 1, 1);
            this.tlpBenchmarkDrawingContainer.Controls.Add(this.lblBenchmarkDrawing, 0, 0);
            this.tlpBenchmarkDrawingContainer.Location = new System.Drawing.Point(267, 15);
            this.tlpBenchmarkDrawingContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBenchmarkDrawingContainer.Name = "tlpBenchmarkDrawingContainer";
            this.tlpBenchmarkDrawingContainer.RowCount = 10;
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBenchmarkDrawingContainer.Size = new System.Drawing.Size(278, 317);
            this.tlpBenchmarkDrawingContainer.TabIndex = 36;
            // 
            // pnlCredits
            // 
            this.pnlCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCredits.Controls.Add(this.lstvCredits);
            this.pnlCredits.Location = new System.Drawing.Point(0, 80);
            this.pnlCredits.Name = "pnlCredits";
            this.pnlCredits.Size = new System.Drawing.Size(1029, 450);
            this.pnlCredits.TabIndex = 12;
            // 
            // pbMainProgress
            // 
            this.pbMainProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMainProgress.Location = new System.Drawing.Point(0, 583);
            this.pbMainProgress.MarqueeAnimationSpeed = 10;
            this.pbMainProgress.Name = "pbMainProgress";
            this.pbMainProgress.Size = new System.Drawing.Size(152, 10);
            this.pbMainProgress.TabIndex = 5;
            // 
            // pnlDebug
            // 
            this.pnlDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDebug.Controls.Add(this.lstvDebugMatchdata);
            this.pnlDebug.Controls.Add(this.lblDebugMatchdata);
            this.pnlDebug.Controls.Add(this.lstvDebugMapdata);
            this.pnlDebug.Controls.Add(this.lblDebugMapdata);
            this.pnlDebug.Controls.Add(this.ntxtDebugUnitLocation);
            this.pnlDebug.Controls.Add(this.ntxtDebugPlayerLocation);
            this.pnlDebug.Controls.Add(this.lstvDebugUnitdata);
            this.pnlDebug.Controls.Add(this.lstvDebugPlayderdata);
            this.pnlDebug.Controls.Add(this.txtDebugUnitMemory);
            this.pnlDebug.Controls.Add(this.lblDebugUnitObjects);
            this.pnlDebug.Controls.Add(this.lblDebugUnitLocation);
            this.pnlDebug.Controls.Add(this.txtDebugUnitname);
            this.pnlDebug.Controls.Add(this.lblDebugUnitname);
            this.pnlDebug.Controls.Add(this.btnDebugUnitForward);
            this.pnlDebug.Controls.Add(this.btnDebugUnitBack);
            this.pnlDebug.Controls.Add(this.lblDebugUnitdata);
            this.pnlDebug.Controls.Add(this.txtDebugPlayerMemory);
            this.pnlDebug.Controls.Add(this.lblDebugPlayerObjects);
            this.pnlDebug.Controls.Add(this.lblDebugPlayerLocation);
            this.pnlDebug.Controls.Add(this.txtDebugPlayername);
            this.pnlDebug.Controls.Add(this.lblDebugPlayername);
            this.pnlDebug.Controls.Add(this.btnDebugPlayerForward);
            this.pnlDebug.Controls.Add(this.btnDebugPlayerBack);
            this.pnlDebug.Controls.Add(this.lblDebugPlayerdata);
            this.pnlDebug.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDebug.Location = new System.Drawing.Point(0, 80);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(1029, 450);
            this.pnlDebug.TabIndex = 12;
            // 
            // txtDebugUnitMemory
            // 
            this.txtDebugUnitMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebugUnitMemory.Enabled = false;
            this.txtDebugUnitMemory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugUnitMemory.Location = new System.Drawing.Point(398, 413);
            this.txtDebugUnitMemory.Name = "txtDebugUnitMemory";
            this.txtDebugUnitMemory.Size = new System.Drawing.Size(180, 27);
            this.txtDebugUnitMemory.TabIndex = 21;
            // 
            // txtDebugUnitname
            // 
            this.txtDebugUnitname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebugUnitname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugUnitname.Location = new System.Drawing.Point(398, 382);
            this.txtDebugUnitname.Name = "txtDebugUnitname";
            this.txtDebugUnitname.Size = new System.Drawing.Size(180, 27);
            this.txtDebugUnitname.TabIndex = 18;
            this.txtDebugUnitname.TextChanged += new System.EventHandler(this.txtDebugUnitname_TextChanged);
            // 
            // txtDebugPlayerMemory
            // 
            this.txtDebugPlayerMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebugPlayerMemory.Enabled = false;
            this.txtDebugPlayerMemory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugPlayerMemory.Location = new System.Drawing.Point(149, 413);
            this.txtDebugPlayerMemory.Name = "txtDebugPlayerMemory";
            this.txtDebugPlayerMemory.Size = new System.Drawing.Size(117, 27);
            this.txtDebugPlayerMemory.TabIndex = 12;
            // 
            // txtDebugPlayername
            // 
            this.txtDebugPlayername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebugPlayername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugPlayername.Location = new System.Drawing.Point(149, 382);
            this.txtDebugPlayername.Name = "txtDebugPlayername";
            this.txtDebugPlayername.Size = new System.Drawing.Size(117, 27);
            this.txtDebugPlayername.TabIndex = 9;
            this.txtDebugPlayername.TextChanged += new System.EventHandler(this.txtDebugPlayername_TextChanged);
            // 
            // pnlApplication
            // 
            this.pnlApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlApplication.Controls.Add(this.wbNews);
            this.pnlApplication.Controls.Add(this.panel1);
            this.pnlApplication.Controls.Add(this.btnRestoreSettings);
            this.pnlApplication.Location = new System.Drawing.Point(0, 80);
            this.pnlApplication.Name = "pnlApplication";
            this.pnlApplication.Size = new System.Drawing.Size(1029, 450);
            this.pnlApplication.TabIndex = 0;
            // 
            // wbNews
            // 
            this.wbNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbNews.Location = new System.Drawing.Point(421, 3);
            this.wbNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNews.Name = "wbNews";
            this.wbNews.Size = new System.Drawing.Size(605, 448);
            this.wbNews.TabIndex = 14;
            this.wbNews.Url = new System.Uri("", System.UriKind.Relative);
            this.wbNews.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.btnAdjustPanels);
            this.panel1.Controls.Add(this.aChBxShowWebContent);
            this.panel1.Controls.Add(this.lblApplicationGlobalSettings);
            this.panel1.Controls.Add(this.lblApplicationMemoryReading);
            this.panel1.Controls.Add(this.lblApplicationGraphicsRefresh);
            this.panel1.Controls.Add(this.chBxLanguage);
            this.panel1.Controls.Add(this.ntxtMemoryRefresh);
            this.panel1.Controls.Add(this.lblApplicationLanguage);
            this.panel1.Controls.Add(this.ntxtGraphicsRefresh);
            this.panel1.Controls.Add(this.aChBxOnlyDrawInForeground);
            this.panel1.Controls.Add(this.lblApplicationReposition);
            this.panel1.Controls.Add(this.btnReposition);
            this.panel1.Controls.Add(this.ktxtReposition);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(320, 315);
            this.panel1.TabIndex = 13;
            // 
            // chBxLanguage
            // 
            this.chBxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chBxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chBxLanguage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBxLanguage.FormattingEnabled = true;
            this.chBxLanguage.Location = new System.Drawing.Point(133, 132);
            this.chBxLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.chBxLanguage.Name = "chBxLanguage";
            this.chBxLanguage.Size = new System.Drawing.Size(170, 28);
            this.chBxLanguage.TabIndex = 10;
            this.chBxLanguage.SelectedIndexChanged += new System.EventHandler(this.chBxLanguage_SelectedIndexChanged);
            // 
            // pnlOverlays
            // 
            this.pnlOverlays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOverlays.Controls.Add(this.pnlOverlayArmy);
            this.pnlOverlays.Controls.Add(this.pnlOverlayApm);
            this.pnlOverlays.Controls.Add(this.pnlOverlayIncome);
            this.pnlOverlays.Controls.Add(this.pnlOverlayResource);
            this.pnlOverlays.Controls.Add(this.pnlPanelContainer);
            this.pnlOverlays.Controls.Add(this.pnlOverlayProductiontab);
            this.pnlOverlays.Controls.Add(this.pnlOverlayUnittab);
            this.pnlOverlays.Controls.Add(this.pnlOverlayMaphack);
            this.pnlOverlays.Controls.Add(this.pnlOverlayWorker);
            this.pnlOverlays.Location = new System.Drawing.Point(0, 80);
            this.pnlOverlays.Name = "pnlOverlays";
            this.pnlOverlays.Size = new System.Drawing.Size(1029, 450);
            this.pnlOverlays.TabIndex = 11;
            // 
            // pnlPanelContainer
            // 
            this.pnlPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysProduction);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysUnits);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysMaphack);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysApm);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysArmy);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysWorker);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysIncome);
            this.pnlPanelContainer.Controls.Add(this.cpnlOverlaysResources);
            this.pnlPanelContainer.Location = new System.Drawing.Point(19, 15);
            this.pnlPanelContainer.Name = "pnlPanelContainer";
            this.pnlPanelContainer.Size = new System.Drawing.Size(824, 52);
            this.pnlPanelContainer.TabIndex = 0;
            this.pnlPanelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawVerticalBorders);
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlugins.Controls.Add(this.btnPluginsInstallPlugin);
            this.pnlPlugins.Controls.Add(this.lblPluginsImageposition);
            this.pnlPlugins.Controls.Add(this.btnPluginsImagesNext);
            this.pnlPlugins.Controls.Add(this.btnPluginsImagesPrevious);
            this.pnlPlugins.Controls.Add(this.pcbPluginsImages);
            this.pnlPlugins.Controls.Add(this.lblPluginImages);
            this.pnlPlugins.Controls.Add(this.lblPluginDescription);
            this.pnlPlugins.Controls.Add(this.rtbPluginsDescription);
            this.pnlPlugins.Controls.Add(this.lstvPluginsAvailablePlugins);
            this.pnlPlugins.Controls.Add(this.lblPluginAvailablePlugins);
            this.pnlPlugins.Controls.Add(this.lstvPluginsLoadedPlugins);
            this.pnlPlugins.Controls.Add(this.lblPluginLoadedPlugins);
            this.pnlPlugins.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPlugins.Location = new System.Drawing.Point(0, 80);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(1029, 450);
            this.pnlPlugins.TabIndex = 13;
            // 
            // pcbPluginsImages
            // 
            this.pcbPluginsImages.BackColor = System.Drawing.Color.Black;
            this.pcbPluginsImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPluginsImages.Location = new System.Drawing.Point(710, 72);
            this.pcbPluginsImages.Name = "pcbPluginsImages";
            this.pcbPluginsImages.Size = new System.Drawing.Size(214, 209);
            this.pcbPluginsImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPluginsImages.TabIndex = 29;
            this.pcbPluginsImages.TabStop = false;
            this.pcbPluginsImages.Click += new System.EventHandler(this.pcbPluginsImages_Click);
            // 
            // rtbPluginsDescription
            // 
            this.rtbPluginsDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPluginsDescription.Location = new System.Drawing.Point(534, 72);
            this.rtbPluginsDescription.Name = "rtbPluginsDescription";
            this.rtbPluginsDescription.Size = new System.Drawing.Size(161, 209);
            this.rtbPluginsDescription.TabIndex = 26;
            this.rtbPluginsDescription.Text = "";
            // 
            // cmPluginInstall
            // 
            this.cmPluginInstall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPluginInstallPlugin});
            this.cmPluginInstall.Name = "cmPluginRemove";
            this.cmPluginInstall.Size = new System.Drawing.Size(143, 26);
            // 
            // tsPluginInstallPlugin
            // 
            this.tsPluginInstallPlugin.Name = "tsPluginInstallPlugin";
            this.tsPluginInstallPlugin.Size = new System.Drawing.Size(142, 22);
            this.tsPluginInstallPlugin.Text = "Install Plugin";
            this.tsPluginInstallPlugin.Click += new System.EventHandler(this.tsPluginInstallPlugin_Click);
            // 
            // cmPluginRemove
            // 
            this.cmPluginRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPluginRemove});
            this.cmPluginRemove.Name = "cmPluginRemove";
            this.cmPluginRemove.Size = new System.Drawing.Size(155, 26);
            // 
            // tsPluginRemove
            // 
            this.tsPluginRemove.Name = "tsPluginRemove";
            this.tsPluginRemove.Size = new System.Drawing.Size(154, 22);
            this.tsPluginRemove.Text = "Remove Plugin";
            this.tsPluginRemove.Click += new System.EventHandler(this.tsPluginRemove_Click);
            // 
            // pnlMainArea
            // 
            this.pnlMainArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.pnlMainArea.Controls.Add(this.lblTabname);
            this.pnlMainArea.Controls.Add(this.pnlVarious);
            this.pnlMainArea.Controls.Add(this.pnlHelpMe);
            this.pnlMainArea.Controls.Add(this.pnlBenchmark);
            this.pnlMainArea.Controls.Add(this.pnlCredits);
            this.pnlMainArea.Controls.Add(this.pnlApplication);
            this.pnlMainArea.Controls.Add(this.pnlPlugins);
            this.pnlMainArea.Controls.Add(this.pnlDebug);
            this.pnlMainArea.Controls.Add(this.pnlOverlays);
            this.pnlMainArea.Location = new System.Drawing.Point(152, 0);
            this.pnlMainArea.Name = "pnlMainArea";
            this.pnlMainArea.Size = new System.Drawing.Size(1029, 531);
            this.pnlMainArea.TabIndex = 6;
            this.pnlMainArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainArea_Paint);
            // 
            // pnlBottomStrip
            // 
            this.pnlBottomStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottomStrip.Controls.Add(this.btnLaunchResource);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchProduction);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchIncome);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchUnit);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchWorker);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchArmy);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchMaphack);
            this.pnlBottomStrip.Controls.Add(this.btnLaunchApm);
            this.pnlBottomStrip.Location = new System.Drawing.Point(152, 531);
            this.pnlBottomStrip.Name = "pnlBottomStrip";
            this.pnlBottomStrip.Size = new System.Drawing.Size(1028, 62);
            this.pnlBottomStrip.TabIndex = 22;
            this.pnlBottomStrip.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawVerticalBorders);
            // 
            // btnLaunchResource
            // 
            this.btnLaunchResource.AutoSize = true;
            this.btnLaunchResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchResource.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchResource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchResource.LanguageFile = "";
            this.btnLaunchResource.Location = new System.Drawing.Point(15, 15);
            this.btnLaunchResource.Name = "btnLaunchResource";
            this.btnLaunchResource.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchResource.TabIndex = 13;
            this.btnLaunchResource.Text = "Resource";
            this.btnLaunchResource.UseVisualStyleBackColor = false;
            this.btnLaunchResource.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchProduction
            // 
            this.btnLaunchProduction.AutoSize = true;
            this.btnLaunchProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchProduction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchProduction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchProduction.LanguageFile = "";
            this.btnLaunchProduction.Location = new System.Drawing.Point(897, 15);
            this.btnLaunchProduction.Name = "btnLaunchProduction";
            this.btnLaunchProduction.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchProduction.TabIndex = 20;
            this.btnLaunchProduction.Text = "Production";
            this.btnLaunchProduction.UseVisualStyleBackColor = false;
            this.btnLaunchProduction.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchIncome
            // 
            this.btnLaunchIncome.AutoSize = true;
            this.btnLaunchIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchIncome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchIncome.LanguageFile = "";
            this.btnLaunchIncome.Location = new System.Drawing.Point(141, 15);
            this.btnLaunchIncome.Name = "btnLaunchIncome";
            this.btnLaunchIncome.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchIncome.TabIndex = 14;
            this.btnLaunchIncome.Text = "Income";
            this.btnLaunchIncome.UseVisualStyleBackColor = false;
            this.btnLaunchIncome.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchUnit
            // 
            this.btnLaunchUnit.AutoSize = true;
            this.btnLaunchUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchUnit.LanguageFile = "";
            this.btnLaunchUnit.Location = new System.Drawing.Point(771, 15);
            this.btnLaunchUnit.Name = "btnLaunchUnit";
            this.btnLaunchUnit.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchUnit.TabIndex = 19;
            this.btnLaunchUnit.Text = "Units";
            this.btnLaunchUnit.UseVisualStyleBackColor = false;
            this.btnLaunchUnit.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchWorker
            // 
            this.btnLaunchWorker.AutoSize = true;
            this.btnLaunchWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchWorker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchWorker.LanguageFile = "";
            this.btnLaunchWorker.Location = new System.Drawing.Point(267, 15);
            this.btnLaunchWorker.Name = "btnLaunchWorker";
            this.btnLaunchWorker.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchWorker.TabIndex = 15;
            this.btnLaunchWorker.Text = "Worker";
            this.btnLaunchWorker.UseVisualStyleBackColor = false;
            this.btnLaunchWorker.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchArmy
            // 
            this.btnLaunchArmy.AutoSize = true;
            this.btnLaunchArmy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchArmy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchArmy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchArmy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchArmy.LanguageFile = "";
            this.btnLaunchArmy.Location = new System.Drawing.Point(645, 15);
            this.btnLaunchArmy.Name = "btnLaunchArmy";
            this.btnLaunchArmy.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchArmy.TabIndex = 17;
            this.btnLaunchArmy.Text = "Army";
            this.btnLaunchArmy.UseVisualStyleBackColor = false;
            this.btnLaunchArmy.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchMaphack
            // 
            this.btnLaunchMaphack.AutoSize = true;
            this.btnLaunchMaphack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchMaphack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchMaphack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchMaphack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchMaphack.LanguageFile = "";
            this.btnLaunchMaphack.Location = new System.Drawing.Point(393, 15);
            this.btnLaunchMaphack.Name = "btnLaunchMaphack";
            this.btnLaunchMaphack.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchMaphack.TabIndex = 18;
            this.btnLaunchMaphack.Text = "Maphack";
            this.btnLaunchMaphack.UseVisualStyleBackColor = false;
            this.btnLaunchMaphack.Click += new System.EventHandler(this.InputManager);
            // 
            // btnLaunchApm
            // 
            this.btnLaunchApm.AutoSize = true;
            this.btnLaunchApm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLaunchApm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLaunchApm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchApm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchApm.LanguageFile = "";
            this.btnLaunchApm.Location = new System.Drawing.Point(519, 15);
            this.btnLaunchApm.Name = "btnLaunchApm";
            this.btnLaunchApm.Size = new System.Drawing.Size(120, 32);
            this.btnLaunchApm.TabIndex = 16;
            this.btnLaunchApm.Text = "Apm";
            this.btnLaunchApm.UseVisualStyleBackColor = false;
            this.btnLaunchApm.Click += new System.EventHandler(this.InputManager);
            // 
            // lblTabname
            // 
            this.lblTabname.AutoSize = true;
            this.lblTabname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblTabname.LanguageFile = "";
            this.lblTabname.Location = new System.Drawing.Point(15, 15);
            this.lblTabname.Name = "lblTabname";
            this.lblTabname.Size = new System.Drawing.Size(118, 30);
            this.lblTabname.TabIndex = 1;
            this.lblTabname.Text = "Application";
            // 
            // btnAdjustPanels
            // 
            this.btnAdjustPanels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjustPanels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnAdjustPanels.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnAdjustPanels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustPanels.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjustPanels.ForeColor = System.Drawing.Color.Red;
            this.btnAdjustPanels.LanguageFile = "";
            this.btnAdjustPanels.Location = new System.Drawing.Point(19, 268);
            this.btnAdjustPanels.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdjustPanels.Name = "btnAdjustPanels";
            this.btnAdjustPanels.Size = new System.Drawing.Size(284, 32);
            this.btnAdjustPanels.TabIndex = 13;
            this.btnAdjustPanels.Text = "Adjust Panels";
            this.btnAdjustPanels.UseVisualStyleBackColor = false;
            this.btnAdjustPanels.Click += new System.EventHandler(this.btnAdjustPanels_Click);
            // 
            // aChBxShowWebContent
            // 
            this.aChBxShowWebContent.AutoSize = true;
            this.aChBxShowWebContent.Checked = false;
            this.aChBxShowWebContent.Clickable = true;
            this.aChBxShowWebContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxShowWebContent.DisplayText = "Show Web Content";
            this.aChBxShowWebContent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aChBxShowWebContent.Location = new System.Drawing.Point(19, 194);
            this.aChBxShowWebContent.Margin = new System.Windows.Forms.Padding(0);
            this.aChBxShowWebContent.Name = "aChBxShowWebContent";
            this.aChBxShowWebContent.Size = new System.Drawing.Size(166, 30);
            this.aChBxShowWebContent.TabIndex = 12;
            this.aChBxShowWebContent.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Left;
            this.aChBxShowWebContent.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.aChBxShowWebContent_CheckedChanged);
            // 
            // lblApplicationGlobalSettings
            // 
            this.lblApplicationGlobalSettings.AutoSize = true;
            this.lblApplicationGlobalSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationGlobalSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblApplicationGlobalSettings.LanguageFile = "";
            this.lblApplicationGlobalSettings.Location = new System.Drawing.Point(15, 15);
            this.lblApplicationGlobalSettings.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationGlobalSettings.Name = "lblApplicationGlobalSettings";
            this.lblApplicationGlobalSettings.Size = new System.Drawing.Size(115, 20);
            this.lblApplicationGlobalSettings.TabIndex = 11;
            this.lblApplicationGlobalSettings.Text = "Global Settings";
            // 
            // lblApplicationMemoryReading
            // 
            this.lblApplicationMemoryReading.AutoSize = true;
            this.lblApplicationMemoryReading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationMemoryReading.LanguageFile = "";
            this.lblApplicationMemoryReading.Location = new System.Drawing.Point(15, 45);
            this.lblApplicationMemoryReading.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationMemoryReading.Name = "lblApplicationMemoryReading";
            this.lblApplicationMemoryReading.Size = new System.Drawing.Size(159, 20);
            this.lblApplicationMemoryReading.TabIndex = 0;
            this.lblApplicationMemoryReading.Text = "Memory Reading (ms):";
            // 
            // lblApplicationGraphicsRefresh
            // 
            this.lblApplicationGraphicsRefresh.AutoSize = true;
            this.lblApplicationGraphicsRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationGraphicsRefresh.LanguageFile = "";
            this.lblApplicationGraphicsRefresh.Location = new System.Drawing.Point(15, 75);
            this.lblApplicationGraphicsRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationGraphicsRefresh.Name = "lblApplicationGraphicsRefresh";
            this.lblApplicationGraphicsRefresh.Size = new System.Drawing.Size(155, 20);
            this.lblApplicationGraphicsRefresh.TabIndex = 1;
            this.lblApplicationGraphicsRefresh.Text = "Graphics Refresh (ms):";
            // 
            // ntxtMemoryRefresh
            // 
            this.ntxtMemoryRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntxtMemoryRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtMemoryRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtMemoryRefresh.Location = new System.Drawing.Point(223, 42);
            this.ntxtMemoryRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ntxtMemoryRefresh.Name = "ntxtMemoryRefresh";
            this.ntxtMemoryRefresh.Number = 42;
            this.ntxtMemoryRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ntxtMemoryRefresh.Size = new System.Drawing.Size(80, 27);
            this.ntxtMemoryRefresh.TabIndex = 2;
            this.ntxtMemoryRefresh.Text = "42";
            this.ntxtMemoryRefresh.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtMemoryRefresh_NumberChanged);
            // 
            // lblApplicationLanguage
            // 
            this.lblApplicationLanguage.AutoSize = true;
            this.lblApplicationLanguage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationLanguage.LanguageFile = "";
            this.lblApplicationLanguage.Location = new System.Drawing.Point(16, 135);
            this.lblApplicationLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationLanguage.Name = "lblApplicationLanguage";
            this.lblApplicationLanguage.Size = new System.Drawing.Size(77, 20);
            this.lblApplicationLanguage.TabIndex = 9;
            this.lblApplicationLanguage.Text = "Language:";
            // 
            // ntxtGraphicsRefresh
            // 
            this.ntxtGraphicsRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ntxtGraphicsRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtGraphicsRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtGraphicsRefresh.Location = new System.Drawing.Point(223, 70);
            this.ntxtGraphicsRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ntxtGraphicsRefresh.Name = "ntxtGraphicsRefresh";
            this.ntxtGraphicsRefresh.Number = 42;
            this.ntxtGraphicsRefresh.Size = new System.Drawing.Size(80, 27);
            this.ntxtGraphicsRefresh.TabIndex = 3;
            this.ntxtGraphicsRefresh.Text = "42";
            this.ntxtGraphicsRefresh.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtGraphicsRefresh_NumberChanged);
            // 
            // aChBxOnlyDrawInForeground
            // 
            this.aChBxOnlyDrawInForeground.AutoSize = true;
            this.aChBxOnlyDrawInForeground.Checked = false;
            this.aChBxOnlyDrawInForeground.Clickable = true;
            this.aChBxOnlyDrawInForeground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxOnlyDrawInForeground.DisplayText = "Only draw when SCII is in foreground";
            this.aChBxOnlyDrawInForeground.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aChBxOnlyDrawInForeground.Location = new System.Drawing.Point(19, 165);
            this.aChBxOnlyDrawInForeground.Margin = new System.Windows.Forms.Padding(0);
            this.aChBxOnlyDrawInForeground.Name = "aChBxOnlyDrawInForeground";
            this.aChBxOnlyDrawInForeground.Size = new System.Drawing.Size(283, 30);
            this.aChBxOnlyDrawInForeground.TabIndex = 8;
            this.aChBxOnlyDrawInForeground.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Left;
            this.aChBxOnlyDrawInForeground.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.chBxOnlyDrawInForeground_CheckedChanged);
            // 
            // lblApplicationReposition
            // 
            this.lblApplicationReposition.AutoSize = true;
            this.lblApplicationReposition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationReposition.LanguageFile = "";
            this.lblApplicationReposition.Location = new System.Drawing.Point(16, 105);
            this.lblApplicationReposition.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplicationReposition.Name = "lblApplicationReposition";
            this.lblApplicationReposition.Size = new System.Drawing.Size(109, 20);
            this.lblApplicationReposition.TabIndex = 4;
            this.lblApplicationReposition.Text = "Reposition key:";
            // 
            // btnReposition
            // 
            this.btnReposition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnReposition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnReposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReposition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReposition.LanguageFile = "";
            this.btnReposition.Location = new System.Drawing.Point(19, 232);
            this.btnReposition.Margin = new System.Windows.Forms.Padding(0);
            this.btnReposition.Name = "btnReposition";
            this.btnReposition.Size = new System.Drawing.Size(284, 32);
            this.btnReposition.TabIndex = 7;
            this.btnReposition.Text = "Reset panelposition and -size";
            this.btnReposition.UseVisualStyleBackColor = false;
            this.btnReposition.Click += new System.EventHandler(this.btnReposition_Click);
            // 
            // ktxtReposition
            // 
            this.ktxtReposition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxtReposition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtReposition.HotKeyValue = System.Windows.Forms.Keys.None;
            this.ktxtReposition.Location = new System.Drawing.Point(223, 102);
            this.ktxtReposition.Margin = new System.Windows.Forms.Padding(0);
            this.ktxtReposition.Name = "ktxtReposition";
            this.ktxtReposition.Size = new System.Drawing.Size(80, 27);
            this.ktxtReposition.TabIndex = 5;
            this.ktxtReposition.KeyChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.KeyValueChangeHandler(this.ktxtReposition_KeyChanged);
            // 
            // btnRestoreSettings
            // 
            this.btnRestoreSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRestoreSettings.AutoSize = true;
            this.btnRestoreSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnRestoreSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnRestoreSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreSettings.LanguageFile = "";
            this.btnRestoreSettings.Location = new System.Drawing.Point(15, 409);
            this.btnRestoreSettings.Name = "btnRestoreSettings";
            this.btnRestoreSettings.Size = new System.Drawing.Size(128, 32);
            this.btnRestoreSettings.TabIndex = 12;
            this.btnRestoreSettings.Text = "Restore Settings";
            this.btnRestoreSettings.UseVisualStyleBackColor = false;
            this.btnRestoreSettings.Click += new System.EventHandler(this.btnRestoreSettings_Click);
            // 
            // btnPluginsInstallPlugin
            // 
            this.btnPluginsInstallPlugin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPluginsInstallPlugin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnPluginsInstallPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsInstallPlugin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluginsInstallPlugin.LanguageFile = "";
            this.btnPluginsInstallPlugin.Location = new System.Drawing.Point(534, 292);
            this.btnPluginsInstallPlugin.Name = "btnPluginsInstallPlugin";
            this.btnPluginsInstallPlugin.Size = new System.Drawing.Size(161, 37);
            this.btnPluginsInstallPlugin.TabIndex = 33;
            this.btnPluginsInstallPlugin.Text = "Install";
            this.btnPluginsInstallPlugin.UseVisualStyleBackColor = false;
            this.btnPluginsInstallPlugin.Click += new System.EventHandler(this.btnPluginsInstallPlugin_Click);
            // 
            // lblPluginsImageposition
            // 
            this.lblPluginsImageposition.AutoSize = true;
            this.lblPluginsImageposition.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginsImageposition.LanguageFile = "";
            this.lblPluginsImageposition.Location = new System.Drawing.Point(801, 300);
            this.lblPluginsImageposition.Name = "lblPluginsImageposition";
            this.lblPluginsImageposition.Size = new System.Drawing.Size(31, 20);
            this.lblPluginsImageposition.TabIndex = 32;
            this.lblPluginsImageposition.Text = "0/0";
            // 
            // btnPluginsImagesNext
            // 
            this.btnPluginsImagesNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPluginsImagesNext.Enabled = false;
            this.btnPluginsImagesNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnPluginsImagesNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsImagesNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluginsImagesNext.LanguageFile = "";
            this.btnPluginsImagesNext.Location = new System.Drawing.Point(897, 292);
            this.btnPluginsImagesNext.Name = "btnPluginsImagesNext";
            this.btnPluginsImagesNext.Size = new System.Drawing.Size(27, 37);
            this.btnPluginsImagesNext.TabIndex = 31;
            this.btnPluginsImagesNext.Text = ">";
            this.btnPluginsImagesNext.UseVisualStyleBackColor = false;
            this.btnPluginsImagesNext.Click += new System.EventHandler(this.btnPluginsImagesNext_Click);
            // 
            // btnPluginsImagesPrevious
            // 
            this.btnPluginsImagesPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPluginsImagesPrevious.Enabled = false;
            this.btnPluginsImagesPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnPluginsImagesPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPluginsImagesPrevious.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPluginsImagesPrevious.LanguageFile = "";
            this.btnPluginsImagesPrevious.Location = new System.Drawing.Point(710, 292);
            this.btnPluginsImagesPrevious.Name = "btnPluginsImagesPrevious";
            this.btnPluginsImagesPrevious.Size = new System.Drawing.Size(27, 37);
            this.btnPluginsImagesPrevious.TabIndex = 30;
            this.btnPluginsImagesPrevious.Text = "<";
            this.btnPluginsImagesPrevious.UseVisualStyleBackColor = false;
            this.btnPluginsImagesPrevious.Click += new System.EventHandler(this.btnPluginsImagesPrevious_Click);
            // 
            // lblPluginImages
            // 
            this.lblPluginImages.AutoSize = true;
            this.lblPluginImages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblPluginImages.LanguageFile = "";
            this.lblPluginImages.Location = new System.Drawing.Point(706, 45);
            this.lblPluginImages.Name = "lblPluginImages";
            this.lblPluginImages.Size = new System.Drawing.Size(60, 20);
            this.lblPluginImages.TabIndex = 28;
            this.lblPluginImages.Text = "Images";
            // 
            // lblPluginDescription
            // 
            this.lblPluginDescription.AutoSize = true;
            this.lblPluginDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblPluginDescription.LanguageFile = "";
            this.lblPluginDescription.Location = new System.Drawing.Point(530, 42);
            this.lblPluginDescription.Name = "lblPluginDescription";
            this.lblPluginDescription.Size = new System.Drawing.Size(89, 20);
            this.lblPluginDescription.TabIndex = 27;
            this.lblPluginDescription.Text = "Description";
            // 
            // lstvPluginsAvailablePlugins
            // 
            this.lstvPluginsAvailablePlugins.AutoArrange = false;
            this.lstvPluginsAvailablePlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPluginsAvailablePluginName,
            this.chPluginsAvailablePluginVersion});
            this.lstvPluginsAvailablePlugins.ContextMenuStrip = this.cmPluginInstall;
            this.lstvPluginsAvailablePlugins.Enabled = false;
            this.lstvPluginsAvailablePlugins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvPluginsAvailablePlugins.FullRowSelect = true;
            this.lstvPluginsAvailablePlugins.GridLines = true;
            this.lstvPluginsAvailablePlugins.Location = new System.Drawing.Point(281, 45);
            this.lstvPluginsAvailablePlugins.MultiSelect = false;
            this.lstvPluginsAvailablePlugins.Name = "lstvPluginsAvailablePlugins";
            this.lstvPluginsAvailablePlugins.Size = new System.Drawing.Size(235, 284);
            this.lstvPluginsAvailablePlugins.TabIndex = 25;
            this.lstvPluginsAvailablePlugins.UseCompatibleStateImageBehavior = false;
            this.lstvPluginsAvailablePlugins.View = System.Windows.Forms.View.Details;
            this.lstvPluginsAvailablePlugins.SelectedIndexChanged += new System.EventHandler(this.lstvPluginsAvailablePlugins_SelectedIndexChanged);
            // 
            // chPluginsAvailablePluginName
            // 
            this.chPluginsAvailablePluginName.Text = "Plugin";
            this.chPluginsAvailablePluginName.Width = 133;
            // 
            // chPluginsAvailablePluginVersion
            // 
            this.chPluginsAvailablePluginVersion.Text = "Version";
            this.chPluginsAvailablePluginVersion.Width = 98;
            // 
            // lblPluginAvailablePlugins
            // 
            this.lblPluginAvailablePlugins.AutoSize = true;
            this.lblPluginAvailablePlugins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginAvailablePlugins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblPluginAvailablePlugins.LanguageFile = "";
            this.lblPluginAvailablePlugins.Location = new System.Drawing.Point(277, 15);
            this.lblPluginAvailablePlugins.Name = "lblPluginAvailablePlugins";
            this.lblPluginAvailablePlugins.Size = new System.Drawing.Size(128, 20);
            this.lblPluginAvailablePlugins.TabIndex = 24;
            this.lblPluginAvailablePlugins.Text = "Available plugins";
            // 
            // lstvPluginsLoadedPlugins
            // 
            this.lstvPluginsLoadedPlugins.AutoArrange = false;
            this.lstvPluginsLoadedPlugins.CheckBoxes = true;
            this.lstvPluginsLoadedPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPluginsLoadedPluginName,
            this.chPluginsLoadedPluginVersion});
            this.lstvPluginsLoadedPlugins.ContextMenuStrip = this.cmPluginRemove;
            this.lstvPluginsLoadedPlugins.Enabled = false;
            this.lstvPluginsLoadedPlugins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvPluginsLoadedPlugins.FullRowSelect = true;
            this.lstvPluginsLoadedPlugins.GridLines = true;
            this.lstvPluginsLoadedPlugins.Location = new System.Drawing.Point(19, 45);
            this.lstvPluginsLoadedPlugins.Name = "lstvPluginsLoadedPlugins";
            this.lstvPluginsLoadedPlugins.Size = new System.Drawing.Size(235, 284);
            this.lstvPluginsLoadedPlugins.TabIndex = 23;
            this.lstvPluginsLoadedPlugins.UseCompatibleStateImageBehavior = false;
            this.lstvPluginsLoadedPlugins.View = System.Windows.Forms.View.Details;
            this.lstvPluginsLoadedPlugins.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvPluginsLoadedPlugins_ItemChecked);
            this.lstvPluginsLoadedPlugins.SelectedIndexChanged += new System.EventHandler(this.lstvPluginsLoadedPlugins_SelectedIndexChanged);
            // 
            // chPluginsLoadedPluginName
            // 
            this.chPluginsLoadedPluginName.Text = "Plugin";
            this.chPluginsLoadedPluginName.Width = 133;
            // 
            // chPluginsLoadedPluginVersion
            // 
            this.chPluginsLoadedPluginVersion.Text = "Version";
            this.chPluginsLoadedPluginVersion.Width = 98;
            // 
            // lblPluginLoadedPlugins
            // 
            this.lblPluginLoadedPlugins.AutoSize = true;
            this.lblPluginLoadedPlugins.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPluginLoadedPlugins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblPluginLoadedPlugins.LanguageFile = "";
            this.lblPluginLoadedPlugins.Location = new System.Drawing.Point(15, 15);
            this.lblPluginLoadedPlugins.Name = "lblPluginLoadedPlugins";
            this.lblPluginLoadedPlugins.Size = new System.Drawing.Size(115, 20);
            this.lblPluginLoadedPlugins.TabIndex = 5;
            this.lblPluginLoadedPlugins.Text = "Loaded plugins";
            // 
            // lstvDebugMatchdata
            // 
            this.lstvDebugMatchdata.AutoArrange = false;
            this.lstvDebugMatchdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDebugMatchDataAttribute,
            this.chDebugMatchDataValue});
            this.lstvDebugMatchdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDebugMatchdata.FullRowSelect = true;
            this.lstvDebugMatchdata.GridLines = true;
            this.lstvDebugMatchdata.Location = new System.Drawing.Point(810, 45);
            this.lstvDebugMatchdata.Name = "lstvDebugMatchdata";
            this.lstvDebugMatchdata.Size = new System.Drawing.Size(200, 284);
            this.lstvDebugMatchdata.TabIndex = 29;
            this.lstvDebugMatchdata.UseCompatibleStateImageBehavior = false;
            this.lstvDebugMatchdata.View = System.Windows.Forms.View.Details;
            // 
            // chDebugMatchDataAttribute
            // 
            this.chDebugMatchDataAttribute.Text = "Attribute";
            this.chDebugMatchDataAttribute.Width = 100;
            // 
            // chDebugMatchDataValue
            // 
            this.chDebugMatchDataValue.Text = "Value";
            this.chDebugMatchDataValue.Width = 96;
            // 
            // lblDebugMatchdata
            // 
            this.lblDebugMatchdata.AutoSize = true;
            this.lblDebugMatchdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugMatchdata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblDebugMatchdata.LanguageFile = "";
            this.lblDebugMatchdata.Location = new System.Drawing.Point(806, 15);
            this.lblDebugMatchdata.Name = "lblDebugMatchdata";
            this.lblDebugMatchdata.Size = new System.Drawing.Size(84, 20);
            this.lblDebugMatchdata.TabIndex = 28;
            this.lblDebugMatchdata.Text = "Matchdata";
            // 
            // lstvDebugMapdata
            // 
            this.lstvDebugMapdata.AutoArrange = false;
            this.lstvDebugMapdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDebugMapDataAttribute,
            this.chDebugMapDataValue});
            this.lstvDebugMapdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDebugMapdata.FullRowSelect = true;
            this.lstvDebugMapdata.GridLines = true;
            this.lstvDebugMapdata.Location = new System.Drawing.Point(593, 45);
            this.lstvDebugMapdata.Name = "lstvDebugMapdata";
            this.lstvDebugMapdata.Size = new System.Drawing.Size(200, 284);
            this.lstvDebugMapdata.TabIndex = 27;
            this.lstvDebugMapdata.UseCompatibleStateImageBehavior = false;
            this.lstvDebugMapdata.View = System.Windows.Forms.View.Details;
            // 
            // chDebugMapDataAttribute
            // 
            this.chDebugMapDataAttribute.Text = "Attribute";
            this.chDebugMapDataAttribute.Width = 100;
            // 
            // chDebugMapDataValue
            // 
            this.chDebugMapDataValue.Text = "Value";
            this.chDebugMapDataValue.Width = 96;
            // 
            // lblDebugMapdata
            // 
            this.lblDebugMapdata.AutoSize = true;
            this.lblDebugMapdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugMapdata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblDebugMapdata.LanguageFile = "";
            this.lblDebugMapdata.Location = new System.Drawing.Point(589, 15);
            this.lblDebugMapdata.Name = "lblDebugMapdata";
            this.lblDebugMapdata.Size = new System.Drawing.Size(71, 20);
            this.lblDebugMapdata.TabIndex = 26;
            this.lblDebugMapdata.Text = "Mapdata";
            // 
            // ntxtDebugUnitLocation
            // 
            this.ntxtDebugUnitLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtDebugUnitLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ntxtDebugUnitLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtDebugUnitLocation.Location = new System.Drawing.Point(314, 340);
            this.ntxtDebugUnitLocation.Name = "ntxtDebugUnitLocation";
            this.ntxtDebugUnitLocation.Number = 1;
            this.ntxtDebugUnitLocation.Size = new System.Drawing.Size(50, 27);
            this.ntxtDebugUnitLocation.TabIndex = 25;
            this.ntxtDebugUnitLocation.Text = "1";
            this.ntxtDebugUnitLocation.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtDebugUnitLocation_NumberChanged);
            // 
            // ntxtDebugPlayerLocation
            // 
            this.ntxtDebugPlayerLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtDebugPlayerLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ntxtDebugPlayerLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtDebugPlayerLocation.Location = new System.Drawing.Point(52, 340);
            this.ntxtDebugPlayerLocation.Name = "ntxtDebugPlayerLocation";
            this.ntxtDebugPlayerLocation.Number = 1;
            this.ntxtDebugPlayerLocation.Size = new System.Drawing.Size(50, 27);
            this.ntxtDebugPlayerLocation.TabIndex = 24;
            this.ntxtDebugPlayerLocation.Text = "1";
            this.ntxtDebugPlayerLocation.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtDebugPlayerLocation_NumberChanged);
            // 
            // lstvDebugUnitdata
            // 
            this.lstvDebugUnitdata.AutoArrange = false;
            this.lstvDebugUnitdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDebugUnitDataAttribute,
            this.chDebugUnitDataValue});
            this.lstvDebugUnitdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDebugUnitdata.FullRowSelect = true;
            this.lstvDebugUnitdata.GridLines = true;
            this.lstvDebugUnitdata.Location = new System.Drawing.Point(281, 45);
            this.lstvDebugUnitdata.Name = "lstvDebugUnitdata";
            this.lstvDebugUnitdata.Size = new System.Drawing.Size(297, 284);
            this.lstvDebugUnitdata.TabIndex = 23;
            this.lstvDebugUnitdata.UseCompatibleStateImageBehavior = false;
            this.lstvDebugUnitdata.View = System.Windows.Forms.View.Details;
            // 
            // chDebugUnitDataAttribute
            // 
            this.chDebugUnitDataAttribute.Text = "Attribute";
            this.chDebugUnitDataAttribute.Width = 133;
            // 
            // chDebugUnitDataValue
            // 
            this.chDebugUnitDataValue.Text = "Value";
            this.chDebugUnitDataValue.Width = 160;
            // 
            // lstvDebugPlayderdata
            // 
            this.lstvDebugPlayderdata.AutoArrange = false;
            this.lstvDebugPlayderdata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDebugPlayerDataAttribute,
            this.chDebugPlayerDataValue});
            this.lstvDebugPlayderdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDebugPlayderdata.FullRowSelect = true;
            this.lstvDebugPlayderdata.GridLines = true;
            this.lstvDebugPlayderdata.Location = new System.Drawing.Point(19, 45);
            this.lstvDebugPlayderdata.Name = "lstvDebugPlayderdata";
            this.lstvDebugPlayderdata.Size = new System.Drawing.Size(247, 284);
            this.lstvDebugPlayderdata.TabIndex = 22;
            this.lstvDebugPlayderdata.UseCompatibleStateImageBehavior = false;
            this.lstvDebugPlayderdata.View = System.Windows.Forms.View.Details;
            // 
            // chDebugPlayerDataAttribute
            // 
            this.chDebugPlayerDataAttribute.Text = "Attribute";
            this.chDebugPlayerDataAttribute.Width = 133;
            // 
            // chDebugPlayerDataValue
            // 
            this.chDebugPlayerDataValue.Text = "Value";
            this.chDebugPlayerDataValue.Width = 110;
            // 
            // lblDebugUnitObjects
            // 
            this.lblDebugUnitObjects.AutoSize = true;
            this.lblDebugUnitObjects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugUnitObjects.LanguageFile = "";
            this.lblDebugUnitObjects.Location = new System.Drawing.Point(277, 415);
            this.lblDebugUnitObjects.Name = "lblDebugUnitObjects";
            this.lblDebugUnitObjects.Size = new System.Drawing.Size(93, 20);
            this.lblDebugUnitObjects.TabIndex = 20;
            this.lblDebugUnitObjects.Text = "Unit Objects:";
            // 
            // lblDebugUnitLocation
            // 
            this.lblDebugUnitLocation.AutoSize = true;
            this.lblDebugUnitLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugUnitLocation.LanguageFile = "";
            this.lblDebugUnitLocation.Location = new System.Drawing.Point(418, 343);
            this.lblDebugUnitLocation.Name = "lblDebugUnitLocation";
            this.lblDebugUnitLocation.Size = new System.Drawing.Size(31, 20);
            this.lblDebugUnitLocation.TabIndex = 19;
            this.lblDebugUnitLocation.Text = "0/0";
            // 
            // lblDebugUnitname
            // 
            this.lblDebugUnitname.AutoSize = true;
            this.lblDebugUnitname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugUnitname.LanguageFile = "";
            this.lblDebugUnitname.Location = new System.Drawing.Point(277, 384);
            this.lblDebugUnitname.Name = "lblDebugUnitname";
            this.lblDebugUnitname.Size = new System.Drawing.Size(76, 20);
            this.lblDebugUnitname.TabIndex = 17;
            this.lblDebugUnitname.Text = "Unitname:";
            // 
            // btnDebugUnitForward
            // 
            this.btnDebugUnitForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDebugUnitForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnDebugUnitForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugUnitForward.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugUnitForward.LanguageFile = "";
            this.btnDebugUnitForward.Location = new System.Drawing.Point(551, 335);
            this.btnDebugUnitForward.Name = "btnDebugUnitForward";
            this.btnDebugUnitForward.Size = new System.Drawing.Size(27, 37);
            this.btnDebugUnitForward.TabIndex = 16;
            this.btnDebugUnitForward.Text = ">";
            this.btnDebugUnitForward.UseVisualStyleBackColor = false;
            this.btnDebugUnitForward.Click += new System.EventHandler(this.btnDebugUnitForward_Click);
            // 
            // btnDebugUnitBack
            // 
            this.btnDebugUnitBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDebugUnitBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnDebugUnitBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugUnitBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugUnitBack.LanguageFile = "";
            this.btnDebugUnitBack.Location = new System.Drawing.Point(281, 335);
            this.btnDebugUnitBack.Name = "btnDebugUnitBack";
            this.btnDebugUnitBack.Size = new System.Drawing.Size(27, 37);
            this.btnDebugUnitBack.TabIndex = 15;
            this.btnDebugUnitBack.Text = "<";
            this.btnDebugUnitBack.UseVisualStyleBackColor = false;
            this.btnDebugUnitBack.Click += new System.EventHandler(this.btnDebugUnitBack_Click);
            // 
            // lblDebugUnitdata
            // 
            this.lblDebugUnitdata.AutoSize = true;
            this.lblDebugUnitdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugUnitdata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblDebugUnitdata.LanguageFile = "";
            this.lblDebugUnitdata.Location = new System.Drawing.Point(277, 15);
            this.lblDebugUnitdata.Name = "lblDebugUnitdata";
            this.lblDebugUnitdata.Size = new System.Drawing.Size(70, 20);
            this.lblDebugUnitdata.TabIndex = 13;
            this.lblDebugUnitdata.Text = "Unitdata";
            // 
            // lblDebugPlayerObjects
            // 
            this.lblDebugPlayerObjects.AutoSize = true;
            this.lblDebugPlayerObjects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugPlayerObjects.LanguageFile = "";
            this.lblDebugPlayerObjects.Location = new System.Drawing.Point(15, 415);
            this.lblDebugPlayerObjects.Name = "lblDebugPlayerObjects";
            this.lblDebugPlayerObjects.Size = new System.Drawing.Size(106, 20);
            this.lblDebugPlayerObjects.TabIndex = 11;
            this.lblDebugPlayerObjects.Text = "Player Objects:";
            // 
            // lblDebugPlayerLocation
            // 
            this.lblDebugPlayerLocation.AutoSize = true;
            this.lblDebugPlayerLocation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugPlayerLocation.LanguageFile = "";
            this.lblDebugPlayerLocation.Location = new System.Drawing.Point(128, 343);
            this.lblDebugPlayerLocation.Name = "lblDebugPlayerLocation";
            this.lblDebugPlayerLocation.Size = new System.Drawing.Size(31, 20);
            this.lblDebugPlayerLocation.TabIndex = 10;
            this.lblDebugPlayerLocation.Text = "0/0";
            // 
            // lblDebugPlayername
            // 
            this.lblDebugPlayername.AutoSize = true;
            this.lblDebugPlayername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugPlayername.LanguageFile = "";
            this.lblDebugPlayername.Location = new System.Drawing.Point(15, 384);
            this.lblDebugPlayername.Name = "lblDebugPlayername";
            this.lblDebugPlayername.Size = new System.Drawing.Size(89, 20);
            this.lblDebugPlayername.TabIndex = 8;
            this.lblDebugPlayername.Text = "Playername:";
            // 
            // btnDebugPlayerForward
            // 
            this.btnDebugPlayerForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDebugPlayerForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnDebugPlayerForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugPlayerForward.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugPlayerForward.LanguageFile = "";
            this.btnDebugPlayerForward.Location = new System.Drawing.Point(239, 335);
            this.btnDebugPlayerForward.Name = "btnDebugPlayerForward";
            this.btnDebugPlayerForward.Size = new System.Drawing.Size(27, 37);
            this.btnDebugPlayerForward.TabIndex = 7;
            this.btnDebugPlayerForward.Text = ">";
            this.btnDebugPlayerForward.UseVisualStyleBackColor = false;
            this.btnDebugPlayerForward.Click += new System.EventHandler(this.btnDebugPlayerForward_Click);
            // 
            // btnDebugPlayerBack
            // 
            this.btnDebugPlayerBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnDebugPlayerBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnDebugPlayerBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugPlayerBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugPlayerBack.LanguageFile = "";
            this.btnDebugPlayerBack.Location = new System.Drawing.Point(19, 335);
            this.btnDebugPlayerBack.Name = "btnDebugPlayerBack";
            this.btnDebugPlayerBack.Size = new System.Drawing.Size(27, 37);
            this.btnDebugPlayerBack.TabIndex = 6;
            this.btnDebugPlayerBack.Text = "<";
            this.btnDebugPlayerBack.UseVisualStyleBackColor = false;
            this.btnDebugPlayerBack.Click += new System.EventHandler(this.btnDebugPlayerBack_Click);
            // 
            // lblDebugPlayerdata
            // 
            this.lblDebugPlayerdata.AutoSize = true;
            this.lblDebugPlayerdata.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugPlayerdata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblDebugPlayerdata.LanguageFile = "";
            this.lblDebugPlayerdata.Location = new System.Drawing.Point(15, 15);
            this.lblDebugPlayerdata.Name = "lblDebugPlayerdata";
            this.lblDebugPlayerdata.Size = new System.Drawing.Size(83, 20);
            this.lblDebugPlayerdata.TabIndex = 4;
            this.lblDebugPlayerdata.Text = "Playerdata";
            // 
            // pnlOverlayArmy
            // 
            this.pnlOverlayArmy.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayArmy.Name = "pnlOverlayArmy";
            this.pnlOverlayArmy.Size = new System.Drawing.Size(456, 346);
            this.pnlOverlayArmy.TabIndex = 4;
            // 
            // pnlOverlayApm
            // 
            this.pnlOverlayApm.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayApm.Name = "pnlOverlayApm";
            this.pnlOverlayApm.Size = new System.Drawing.Size(456, 346);
            this.pnlOverlayApm.TabIndex = 3;
            // 
            // pnlOverlayIncome
            // 
            this.pnlOverlayIncome.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayIncome.Name = "pnlOverlayIncome";
            this.pnlOverlayIncome.Size = new System.Drawing.Size(456, 346);
            this.pnlOverlayIncome.TabIndex = 2;
            // 
            // pnlOverlayResource
            // 
            this.pnlOverlayResource.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayResource.Name = "pnlOverlayResource";
            this.pnlOverlayResource.Size = new System.Drawing.Size(456, 346);
            this.pnlOverlayResource.TabIndex = 1;
            // 
            // cpnlOverlaysProduction
            // 
            this.cpnlOverlaysProduction.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysProduction.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysProduction.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysProduction.AutoSize = true;
            this.cpnlOverlaysProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysProduction.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysProduction.DisplayText = "Production";
            this.cpnlOverlaysProduction.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysProduction.Icon = null;
            this.cpnlOverlaysProduction.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysProduction.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysProduction.IsClicked = false;
            this.cpnlOverlaysProduction.IsHovering = false;
            this.cpnlOverlaysProduction.Location = new System.Drawing.Point(721, 1);
            this.cpnlOverlaysProduction.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysProduction.Name = "cpnlOverlaysProduction";
            this.cpnlOverlaysProduction.SettingsPanel = null;
            this.cpnlOverlaysProduction.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysProduction.TabIndex = 4;
            this.cpnlOverlaysProduction.TextSize = 11F;
            this.cpnlOverlaysProduction.Click += new System.EventHandler(this.cpnlOverlaysProduction_Click);
            // 
            // cpnlOverlaysUnits
            // 
            this.cpnlOverlaysUnits.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysUnits.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysUnits.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysUnits.AutoSize = true;
            this.cpnlOverlaysUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysUnits.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysUnits.DisplayText = "Units";
            this.cpnlOverlaysUnits.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysUnits.Icon = null;
            this.cpnlOverlaysUnits.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysUnits.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysUnits.IsClicked = false;
            this.cpnlOverlaysUnits.IsHovering = false;
            this.cpnlOverlaysUnits.Location = new System.Drawing.Point(618, 1);
            this.cpnlOverlaysUnits.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysUnits.Name = "cpnlOverlaysUnits";
            this.cpnlOverlaysUnits.SettingsPanel = null;
            this.cpnlOverlaysUnits.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysUnits.TabIndex = 4;
            this.cpnlOverlaysUnits.TextSize = 11F;
            this.cpnlOverlaysUnits.Click += new System.EventHandler(this.cpnlOverlaysUnits_Click);
            // 
            // cpnlOverlaysMaphack
            // 
            this.cpnlOverlaysMaphack.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysMaphack.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysMaphack.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysMaphack.AutoSize = true;
            this.cpnlOverlaysMaphack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysMaphack.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysMaphack.DisplayText = "Maphack";
            this.cpnlOverlaysMaphack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysMaphack.Icon = null;
            this.cpnlOverlaysMaphack.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysMaphack.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysMaphack.IsClicked = false;
            this.cpnlOverlaysMaphack.IsHovering = false;
            this.cpnlOverlaysMaphack.Location = new System.Drawing.Point(515, 1);
            this.cpnlOverlaysMaphack.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysMaphack.Name = "cpnlOverlaysMaphack";
            this.cpnlOverlaysMaphack.SettingsPanel = null;
            this.cpnlOverlaysMaphack.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysMaphack.TabIndex = 4;
            this.cpnlOverlaysMaphack.TextSize = 11F;
            this.cpnlOverlaysMaphack.Click += new System.EventHandler(this.cpnlOverlaysMaphack_Click);
            // 
            // cpnlOverlaysApm
            // 
            this.cpnlOverlaysApm.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysApm.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysApm.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysApm.AutoSize = true;
            this.cpnlOverlaysApm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysApm.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysApm.DisplayText = "Apm";
            this.cpnlOverlaysApm.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysApm.Icon = null;
            this.cpnlOverlaysApm.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysApm.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysApm.IsClicked = false;
            this.cpnlOverlaysApm.IsHovering = false;
            this.cpnlOverlaysApm.Location = new System.Drawing.Point(412, 1);
            this.cpnlOverlaysApm.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysApm.Name = "cpnlOverlaysApm";
            this.cpnlOverlaysApm.SettingsPanel = null;
            this.cpnlOverlaysApm.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysApm.TabIndex = 3;
            this.cpnlOverlaysApm.TextSize = 11F;
            this.cpnlOverlaysApm.Click += new System.EventHandler(this.cpnlOverlaysApm_Click);
            // 
            // cpnlOverlaysArmy
            // 
            this.cpnlOverlaysArmy.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysArmy.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysArmy.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysArmy.AutoSize = true;
            this.cpnlOverlaysArmy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysArmy.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysArmy.DisplayText = "Army";
            this.cpnlOverlaysArmy.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysArmy.Icon = null;
            this.cpnlOverlaysArmy.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysArmy.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysArmy.IsClicked = false;
            this.cpnlOverlaysArmy.IsHovering = false;
            this.cpnlOverlaysArmy.Location = new System.Drawing.Point(309, 1);
            this.cpnlOverlaysArmy.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysArmy.Name = "cpnlOverlaysArmy";
            this.cpnlOverlaysArmy.SettingsPanel = null;
            this.cpnlOverlaysArmy.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysArmy.TabIndex = 3;
            this.cpnlOverlaysArmy.TextSize = 11F;
            this.cpnlOverlaysArmy.Click += new System.EventHandler(this.cpnlOverlaysArmy_Click);
            // 
            // cpnlOverlaysWorker
            // 
            this.cpnlOverlaysWorker.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysWorker.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysWorker.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysWorker.AutoSize = true;
            this.cpnlOverlaysWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysWorker.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysWorker.DisplayText = "Worker";
            this.cpnlOverlaysWorker.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysWorker.Icon = null;
            this.cpnlOverlaysWorker.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysWorker.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysWorker.IsClicked = false;
            this.cpnlOverlaysWorker.IsHovering = false;
            this.cpnlOverlaysWorker.Location = new System.Drawing.Point(206, 1);
            this.cpnlOverlaysWorker.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysWorker.Name = "cpnlOverlaysWorker";
            this.cpnlOverlaysWorker.SettingsPanel = null;
            this.cpnlOverlaysWorker.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysWorker.TabIndex = 3;
            this.cpnlOverlaysWorker.TextSize = 11F;
            this.cpnlOverlaysWorker.Click += new System.EventHandler(this.cpnlOverlaysWorker_Click);
            // 
            // cpnlOverlaysIncome
            // 
            this.cpnlOverlaysIncome.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysIncome.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysIncome.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysIncome.AutoSize = true;
            this.cpnlOverlaysIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysIncome.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysIncome.DisplayText = "Income";
            this.cpnlOverlaysIncome.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysIncome.Icon = null;
            this.cpnlOverlaysIncome.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysIncome.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysIncome.IsClicked = false;
            this.cpnlOverlaysIncome.IsHovering = false;
            this.cpnlOverlaysIncome.Location = new System.Drawing.Point(103, 1);
            this.cpnlOverlaysIncome.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysIncome.Name = "cpnlOverlaysIncome";
            this.cpnlOverlaysIncome.SettingsPanel = null;
            this.cpnlOverlaysIncome.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysIncome.TabIndex = 2;
            this.cpnlOverlaysIncome.TextSize = 11F;
            this.cpnlOverlaysIncome.Click += new System.EventHandler(this.cpnlOverlaysIncome_Click);
            // 
            // cpnlOverlaysResources
            // 
            this.cpnlOverlaysResources.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysResources.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Bottom;
            this.cpnlOverlaysResources.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysResources.AutoSize = true;
            this.cpnlOverlaysResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysResources.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysResources.DisplayText = "Resources";
            this.cpnlOverlaysResources.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cpnlOverlaysResources.Icon = null;
            this.cpnlOverlaysResources.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cpnlOverlaysResources.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlaysResources.IsClicked = false;
            this.cpnlOverlaysResources.IsHovering = false;
            this.cpnlOverlaysResources.Location = new System.Drawing.Point(0, 1);
            this.cpnlOverlaysResources.Margin = new System.Windows.Forms.Padding(0);
            this.cpnlOverlaysResources.Name = "cpnlOverlaysResources";
            this.cpnlOverlaysResources.SettingsPanel = null;
            this.cpnlOverlaysResources.Size = new System.Drawing.Size(103, 50);
            this.cpnlOverlaysResources.TabIndex = 1;
            this.cpnlOverlaysResources.TextSize = 11F;
            this.cpnlOverlaysResources.Click += new System.EventHandler(this.cpnlOverlaysResources_Click);
            // 
            // pnlOverlayProductiontab
            // 
            this.pnlOverlayProductiontab.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayProductiontab.Name = "pnlOverlayProductiontab";
            this.pnlOverlayProductiontab.Size = new System.Drawing.Size(912, 348);
            this.pnlOverlayProductiontab.TabIndex = 8;
            // 
            // pnlOverlayUnittab
            // 
            this.pnlOverlayUnittab.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayUnittab.Name = "pnlOverlayUnittab";
            this.pnlOverlayUnittab.Size = new System.Drawing.Size(905, 348);
            this.pnlOverlayUnittab.TabIndex = 7;
            // 
            // pnlOverlayMaphack
            // 
            this.pnlOverlayMaphack.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayMaphack.Name = "pnlOverlayMaphack";
            this.pnlOverlayMaphack.Size = new System.Drawing.Size(958, 274);
            this.pnlOverlayMaphack.TabIndex = 6;
            // 
            // pnlOverlayWorker
            // 
            this.pnlOverlayWorker.Location = new System.Drawing.Point(19, 75);
            this.pnlOverlayWorker.Name = "pnlOverlayWorker";
            this.pnlOverlayWorker.Size = new System.Drawing.Size(451, 262);
            this.pnlOverlayWorker.TabIndex = 5;
            // 
            // btnVariousOpenAlerts
            // 
            this.btnVariousOpenAlerts.AutoSize = true;
            this.btnVariousOpenAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnVariousOpenAlerts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnVariousOpenAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariousOpenAlerts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariousOpenAlerts.LanguageFile = "";
            this.btnVariousOpenAlerts.Location = new System.Drawing.Point(186, 320);
            this.btnVariousOpenAlerts.Name = "btnVariousOpenAlerts";
            this.btnVariousOpenAlerts.Size = new System.Drawing.Size(42, 32);
            this.btnVariousOpenAlerts.TabIndex = 21;
            this.btnVariousOpenAlerts.Text = "...";
            this.btnVariousOpenAlerts.UseVisualStyleBackColor = false;
            this.btnVariousOpenAlerts.Click += new System.EventHandler(this.btnVariousOpenAlerts_Click);
            // 
            // lblVariousShowAlert
            // 
            this.lblVariousShowAlert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVariousShowAlert.AutoSize = true;
            this.lblVariousShowAlert.LanguageFile = "";
            this.lblVariousShowAlert.Location = new System.Drawing.Point(0, 3);
            this.lblVariousShowAlert.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousShowAlert.Name = "lblVariousShowAlert";
            this.lblVariousShowAlert.Size = new System.Drawing.Size(119, 20);
            this.lblVariousShowAlert.TabIndex = 19;
            this.lblVariousShowAlert.Text = "Display for (sec.)";
            // 
            // ntxtVariousAlertShowDuration
            // 
            this.ntxtVariousAlertShowDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtVariousAlertShowDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtVariousAlertShowDuration.Location = new System.Drawing.Point(119, 0);
            this.ntxtVariousAlertShowDuration.Margin = new System.Windows.Forms.Padding(0);
            this.ntxtVariousAlertShowDuration.Name = "ntxtVariousAlertShowDuration";
            this.ntxtVariousAlertShowDuration.Number = 1;
            this.ntxtVariousAlertShowDuration.Size = new System.Drawing.Size(47, 27);
            this.ntxtVariousAlertShowDuration.TabIndex = 20;
            this.ntxtVariousAlertShowDuration.Text = "1";
            this.ntxtVariousAlertShowDuration.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtVariousAlertShowDuration_NumberChanged);
            // 
            // aChBxVariousAlertSoundNotification
            // 
            this.aChBxVariousAlertSoundNotification.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousAlertSoundNotification.Checked = false;
            this.aChBxVariousAlertSoundNotification.Clickable = true;
            this.aChBxVariousAlertSoundNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousAlertSoundNotification.DisplayText = "Sound Notification";
            this.aChBxVariousAlertSoundNotification.Location = new System.Drawing.Point(3, 358);
            this.aChBxVariousAlertSoundNotification.Name = "aChBxVariousAlertSoundNotification";
            this.aChBxVariousAlertSoundNotification.Size = new System.Drawing.Size(164, 30);
            this.aChBxVariousAlertSoundNotification.TabIndex = 23;
            this.aChBxVariousAlertSoundNotification.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousAlertSoundNotification.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.aChBxVariousAlertSoundNotification_CheckedChanged);
            // 
            // aChBxVariousShowAlerts
            // 
            this.aChBxVariousShowAlerts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousShowAlerts.Checked = false;
            this.aChBxVariousShowAlerts.Clickable = true;
            this.aChBxVariousShowAlerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousShowAlerts.DisplayText = "Show Alerts";
            this.aChBxVariousShowAlerts.Location = new System.Drawing.Point(3, 321);
            this.aChBxVariousShowAlerts.Name = "aChBxVariousShowAlerts";
            this.aChBxVariousShowAlerts.Size = new System.Drawing.Size(117, 30);
            this.aChBxVariousShowAlerts.TabIndex = 22;
            this.aChBxVariousShowAlerts.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousShowAlerts.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.aChBxVariousShowAlerts_CheckedChanged);
            // 
            // lblVariousDisableAfter
            // 
            this.lblVariousDisableAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVariousDisableAfter.AutoSize = true;
            this.lblVariousDisableAfter.LanguageFile = "";
            this.lblVariousDisableAfter.Location = new System.Drawing.Point(0, 3);
            this.lblVariousDisableAfter.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousDisableAfter.Name = "lblVariousDisableAfter";
            this.lblVariousDisableAfter.Size = new System.Drawing.Size(133, 20);
            this.lblVariousDisableAfter.TabIndex = 19;
            this.lblVariousDisableAfter.Text = "Disable after (min)";
            // 
            // ntxtVariousWorkerCoachDisableAfter
            // 
            this.ntxtVariousWorkerCoachDisableAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtVariousWorkerCoachDisableAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtVariousWorkerCoachDisableAfter.Location = new System.Drawing.Point(133, 0);
            this.ntxtVariousWorkerCoachDisableAfter.Margin = new System.Windows.Forms.Padding(0);
            this.ntxtVariousWorkerCoachDisableAfter.Name = "ntxtVariousWorkerCoachDisableAfter";
            this.ntxtVariousWorkerCoachDisableAfter.Number = 1;
            this.ntxtVariousWorkerCoachDisableAfter.Size = new System.Drawing.Size(47, 27);
            this.ntxtVariousWorkerCoachDisableAfter.TabIndex = 20;
            this.ntxtVariousWorkerCoachDisableAfter.Text = "1";
            this.ntxtVariousWorkerCoachDisableAfter.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtVariousWorkerCoachDisableAfter_NumberChanged);
            // 
            // aChBxVariousPersonalApmAlert
            // 
            this.aChBxVariousPersonalApmAlert.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousPersonalApmAlert.Checked = false;
            this.aChBxVariousPersonalApmAlert.Clickable = true;
            this.aChBxVariousPersonalApmAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousPersonalApmAlert.DisplayText = "Apm Alert";
            this.aChBxVariousPersonalApmAlert.Location = new System.Drawing.Point(0, 0);
            this.aChBxVariousPersonalApmAlert.Margin = new System.Windows.Forms.Padding(0);
            this.aChBxVariousPersonalApmAlert.Name = "aChBxVariousPersonalApmAlert";
            this.aChBxVariousPersonalApmAlert.Size = new System.Drawing.Size(107, 30);
            this.aChBxVariousPersonalApmAlert.TabIndex = 15;
            this.aChBxVariousPersonalApmAlert.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousPersonalApmAlert.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.chBxVariousPersonalApmAlert_CheckedChanged);
            // 
            // ntxtVariousApmLimit
            // 
            this.ntxtVariousApmLimit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ntxtVariousApmLimit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtVariousApmLimit.Location = new System.Drawing.Point(107, 1);
            this.ntxtVariousApmLimit.Margin = new System.Windows.Forms.Padding(0);
            this.ntxtVariousApmLimit.Name = "ntxtVariousApmLimit";
            this.ntxtVariousApmLimit.Number = 1;
            this.ntxtVariousApmLimit.Size = new System.Drawing.Size(49, 27);
            this.ntxtVariousApmLimit.TabIndex = 16;
            this.ntxtVariousApmLimit.Text = "1";
            this.ntxtVariousApmLimit.NumberChanged += new Utilities.Events.NumberChangeHandler(this.ntxtVariousApmLimit_NumberChanged);
            // 
            // lblVariousPersonalApm
            // 
            this.lblVariousPersonalApm.AutoSize = true;
            this.lblVariousPersonalApm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariousPersonalApm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblVariousPersonalApm.LanguageFile = "";
            this.lblVariousPersonalApm.Location = new System.Drawing.Point(0, 0);
            this.lblVariousPersonalApm.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousPersonalApm.Name = "lblVariousPersonalApm";
            this.lblVariousPersonalApm.Size = new System.Drawing.Size(107, 20);
            this.lblVariousPersonalApm.TabIndex = 13;
            this.lblVariousPersonalApm.Text = "Personal Apm";
            // 
            // aChBxVariousShowPersonalApm
            // 
            this.aChBxVariousShowPersonalApm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousShowPersonalApm.Checked = false;
            this.aChBxVariousShowPersonalApm.Clickable = true;
            this.aChBxVariousShowPersonalApm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousShowPersonalApm.DisplayText = "Show Personal Apm";
            this.aChBxVariousShowPersonalApm.Location = new System.Drawing.Point(3, 23);
            this.aChBxVariousShowPersonalApm.Name = "aChBxVariousShowPersonalApm";
            this.aChBxVariousShowPersonalApm.Size = new System.Drawing.Size(171, 30);
            this.aChBxVariousShowPersonalApm.TabIndex = 14;
            this.aChBxVariousShowPersonalApm.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousShowPersonalApm.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.chBxVariousShowPersonalApm_CheckedChanged);
            // 
            // aChBxVariousWorkerCoach
            // 
            this.aChBxVariousWorkerCoach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousWorkerCoach.Checked = false;
            this.aChBxVariousWorkerCoach.Clickable = true;
            this.aChBxVariousWorkerCoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousWorkerCoach.DisplayText = "Show Worker Coach";
            this.aChBxVariousWorkerCoach.Location = new System.Drawing.Point(3, 211);
            this.aChBxVariousWorkerCoach.Name = "aChBxVariousWorkerCoach";
            this.aChBxVariousWorkerCoach.Size = new System.Drawing.Size(172, 30);
            this.aChBxVariousWorkerCoach.TabIndex = 16;
            this.aChBxVariousWorkerCoach.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousWorkerCoach.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.chBxVariousWorkerCoach_CheckedChanged);
            // 
            // lblVariousWorkerCoach
            // 
            this.lblVariousWorkerCoach.AutoSize = true;
            this.lblVariousWorkerCoach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariousWorkerCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblVariousWorkerCoach.LanguageFile = "";
            this.lblVariousWorkerCoach.Location = new System.Drawing.Point(0, 188);
            this.lblVariousWorkerCoach.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousWorkerCoach.Name = "lblVariousWorkerCoach";
            this.lblVariousWorkerCoach.Size = new System.Drawing.Size(107, 20);
            this.lblVariousWorkerCoach.TabIndex = 18;
            this.lblVariousWorkerCoach.Text = "Worker Coach";
            // 
            // lblVariousPersonalClock
            // 
            this.lblVariousPersonalClock.AutoSize = true;
            this.lblVariousPersonalClock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariousPersonalClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblVariousPersonalClock.LanguageFile = "";
            this.lblVariousPersonalClock.Location = new System.Drawing.Point(0, 112);
            this.lblVariousPersonalClock.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousPersonalClock.Name = "lblVariousPersonalClock";
            this.lblVariousPersonalClock.Size = new System.Drawing.Size(110, 20);
            this.lblVariousPersonalClock.TabIndex = 17;
            this.lblVariousPersonalClock.Text = "Personal Clock";
            // 
            // aChBxVariousShowPersonalClock
            // 
            this.aChBxVariousShowPersonalClock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.aChBxVariousShowPersonalClock.Checked = false;
            this.aChBxVariousShowPersonalClock.Clickable = true;
            this.aChBxVariousShowPersonalClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aChBxVariousShowPersonalClock.DisplayText = "Show Personal Clock";
            this.aChBxVariousShowPersonalClock.Location = new System.Drawing.Point(3, 135);
            this.aChBxVariousShowPersonalClock.Name = "aChBxVariousShowPersonalClock";
            this.aChBxVariousShowPersonalClock.Size = new System.Drawing.Size(175, 30);
            this.aChBxVariousShowPersonalClock.TabIndex = 15;
            this.aChBxVariousShowPersonalClock.TextAlign = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.AnotherCheckbox.TextAlignment.Right;
            this.aChBxVariousShowPersonalClock.CheckedChanged += new AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.CheckedChangeHandler(this.chBxVariousShowPersonalClock_CheckedChanged);
            // 
            // lblVariousAlerts
            // 
            this.lblVariousAlerts.AutoSize = true;
            this.lblVariousAlerts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariousAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblVariousAlerts.LanguageFile = "";
            this.lblVariousAlerts.Location = new System.Drawing.Point(0, 297);
            this.lblVariousAlerts.Margin = new System.Windows.Forms.Padding(0);
            this.lblVariousAlerts.Name = "lblVariousAlerts";
            this.lblVariousAlerts.Size = new System.Drawing.Size(51, 20);
            this.lblVariousAlerts.TabIndex = 24;
            this.lblVariousAlerts.Text = "Alerts";
            // 
            // btnHelpMeCopyEmail
            // 
            this.btnHelpMeCopyEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMeCopyEmail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMeCopyEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMeCopyEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMeCopyEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpMeCopyEmail.Image")));
            this.btnHelpMeCopyEmail.LanguageFile = "";
            this.btnHelpMeCopyEmail.Location = new System.Drawing.Point(420, 86);
            this.btnHelpMeCopyEmail.Name = "btnHelpMeCopyEmail";
            this.btnHelpMeCopyEmail.Size = new System.Drawing.Size(29, 32);
            this.btnHelpMeCopyEmail.TabIndex = 31;
            this.btnHelpMeCopyEmail.UseVisualStyleBackColor = false;
            this.btnHelpMeCopyEmail.Click += new System.EventHandler(this.btnHelpMeCopyEmail_Click);
            // 
            // btnHelpMeCopyBitcoin
            // 
            this.btnHelpMeCopyBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMeCopyBitcoin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMeCopyBitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMeCopyBitcoin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMeCopyBitcoin.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpMeCopyBitcoin.Image")));
            this.btnHelpMeCopyBitcoin.LanguageFile = "";
            this.btnHelpMeCopyBitcoin.Location = new System.Drawing.Point(376, 369);
            this.btnHelpMeCopyBitcoin.Name = "btnHelpMeCopyBitcoin";
            this.btnHelpMeCopyBitcoin.Size = new System.Drawing.Size(29, 32);
            this.btnHelpMeCopyBitcoin.TabIndex = 30;
            this.btnHelpMeCopyBitcoin.UseVisualStyleBackColor = false;
            this.btnHelpMeCopyBitcoin.Click += new System.EventHandler(this.btnHelpMeCopyBitcoin_Click);
            // 
            // lblHelpMeBitcoin
            // 
            this.lblHelpMeBitcoin.AutoSize = true;
            this.lblHelpMeBitcoin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHelpMeBitcoin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMeBitcoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblHelpMeBitcoin.LanguageFile = "";
            this.lblHelpMeBitcoin.Location = new System.Drawing.Point(16, 375);
            this.lblHelpMeBitcoin.Name = "lblHelpMeBitcoin";
            this.lblHelpMeBitcoin.Size = new System.Drawing.Size(354, 20);
            this.lblHelpMeBitcoin.TabIndex = 29;
            this.lblHelpMeBitcoin.Text = "Bitcoins: 14H1z2mT8yCQV7h3ZnBF4EBCPV7k8Udsnv";
            // 
            // btnHelpMePaypal
            // 
            this.btnHelpMePaypal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMePaypal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMePaypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMePaypal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMePaypal.LanguageFile = "";
            this.btnHelpMePaypal.Location = new System.Drawing.Point(19, 331);
            this.btnHelpMePaypal.Name = "btnHelpMePaypal";
            this.btnHelpMePaypal.Size = new System.Drawing.Size(206, 32);
            this.btnHelpMePaypal.TabIndex = 28;
            this.btnHelpMePaypal.Text = "Paypal";
            this.btnHelpMePaypal.UseVisualStyleBackColor = false;
            this.btnHelpMePaypal.Click += new System.EventHandler(this.btnHelpMePaypal_Click);
            // 
            // lblHelpCash
            // 
            this.lblHelpCash.AutoSize = true;
            this.lblHelpCash.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblHelpCash.LanguageFile = "";
            this.lblHelpCash.Location = new System.Drawing.Point(15, 300);
            this.lblHelpCash.Name = "lblHelpCash";
            this.lblHelpCash.Size = new System.Drawing.Size(105, 20);
            this.lblHelpCash.TabIndex = 27;
            this.lblHelpCash.Text = "Good \'ol Cash";
            // 
            // btnHelpMeLocalize
            // 
            this.btnHelpMeLocalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMeLocalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMeLocalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMeLocalize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMeLocalize.LanguageFile = "";
            this.btnHelpMeLocalize.Location = new System.Drawing.Point(20, 230);
            this.btnHelpMeLocalize.Name = "btnHelpMeLocalize";
            this.btnHelpMeLocalize.Size = new System.Drawing.Size(206, 32);
            this.btnHelpMeLocalize.TabIndex = 26;
            this.btnHelpMeLocalize.Text = "Get the file and Translate!";
            this.btnHelpMeLocalize.UseVisualStyleBackColor = false;
            this.btnHelpMeLocalize.Click += new System.EventHandler(this.btnHelpMeLocalize_Click);
            // 
            // btnHelpMeGithubIssues
            // 
            this.btnHelpMeGithubIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMeGithubIssues.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMeGithubIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMeGithubIssues.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMeGithubIssues.LanguageFile = "";
            this.btnHelpMeGithubIssues.Location = new System.Drawing.Point(20, 124);
            this.btnHelpMeGithubIssues.Name = "btnHelpMeGithubIssues";
            this.btnHelpMeGithubIssues.Size = new System.Drawing.Size(206, 32);
            this.btnHelpMeGithubIssues.TabIndex = 25;
            this.btnHelpMeGithubIssues.Text = "Github Issues";
            this.btnHelpMeGithubIssues.UseVisualStyleBackColor = false;
            this.btnHelpMeGithubIssues.Click += new System.EventHandler(this.btnHelpMeGithubIssues_Click);
            // 
            // lblHelpLocalize
            // 
            this.lblHelpLocalize.AutoSize = true;
            this.lblHelpLocalize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpLocalize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblHelpLocalize.LanguageFile = "";
            this.lblHelpLocalize.Location = new System.Drawing.Point(16, 198);
            this.lblHelpLocalize.Name = "lblHelpLocalize";
            this.lblHelpLocalize.Size = new System.Drawing.Size(152, 20);
            this.lblHelpLocalize.TabIndex = 24;
            this.lblHelpLocalize.Text = "Help me localize this";
            // 
            // lblHelpMeEmail
            // 
            this.lblHelpMeEmail.AutoSize = true;
            this.lblHelpMeEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHelpMeEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblHelpMeEmail.LanguageFile = "";
            this.lblHelpMeEmail.Location = new System.Drawing.Point(235, 92);
            this.lblHelpMeEmail.Name = "lblHelpMeEmail";
            this.lblHelpMeEmail.Size = new System.Drawing.Size(179, 20);
            this.lblHelpMeEmail.TabIndex = 23;
            this.lblHelpMeEmail.Text = "bpatriciaella@yahoo.com";
            // 
            // btnHelpMeEmailMe
            // 
            this.btnHelpMeEmailMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMeEmailMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMeEmailMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMeEmailMe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMeEmailMe.LanguageFile = "";
            this.btnHelpMeEmailMe.Location = new System.Drawing.Point(20, 86);
            this.btnHelpMeEmailMe.Name = "btnHelpMeEmailMe";
            this.btnHelpMeEmailMe.Size = new System.Drawing.Size(206, 32);
            this.btnHelpMeEmailMe.TabIndex = 22;
            this.btnHelpMeEmailMe.Text = "E-Mail me";
            this.btnHelpMeEmailMe.UseVisualStyleBackColor = false;
            this.btnHelpMeEmailMe.Click += new System.EventHandler(this.btnHelpMeEmailMe_Click);
            // 
            // btnHelpMePostOnD3scene
            // 
            this.btnHelpMePostOnD3scene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHelpMePostOnD3scene.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnHelpMePostOnD3scene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMePostOnD3scene.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMePostOnD3scene.LanguageFile = "";
            this.btnHelpMePostOnD3scene.Location = new System.Drawing.Point(20, 48);
            this.btnHelpMePostOnD3scene.Name = "btnHelpMePostOnD3scene";
            this.btnHelpMePostOnD3scene.Size = new System.Drawing.Size(206, 32);
            this.btnHelpMePostOnD3scene.TabIndex = 21;
            this.btnHelpMePostOnD3scene.Text = "Post on D3Scene";
            this.btnHelpMePostOnD3scene.UseVisualStyleBackColor = false;
            this.btnHelpMePostOnD3scene.Click += new System.EventHandler(this.btnHelpMePostOnD3scene_Click);
            // 
            // lblHelpSuggestionsBug
            // 
            this.lblHelpSuggestionsBug.AutoSize = true;
            this.lblHelpSuggestionsBug.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpSuggestionsBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblHelpSuggestionsBug.LanguageFile = "";
            this.lblHelpSuggestionsBug.Location = new System.Drawing.Point(15, 15);
            this.lblHelpSuggestionsBug.Name = "lblHelpSuggestionsBug";
            this.lblHelpSuggestionsBug.Size = new System.Drawing.Size(260, 20);
            this.lblHelpSuggestionsBug.TabIndex = 12;
            this.lblHelpSuggestionsBug.Text = "Provide suggestions or report a bug";
            // 
            // lblBenchmarkData
            // 
            this.lblBenchmarkData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkData.AutoSize = true;
            this.lblBenchmarkData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkData.LanguageFile = "";
            this.lblBenchmarkData.Location = new System.Drawing.Point(3, 0);
            this.lblBenchmarkData.Name = "lblBenchmarkData";
            this.lblBenchmarkData.Size = new System.Drawing.Size(106, 20);
            this.lblBenchmarkData.TabIndex = 12;
            this.lblBenchmarkData.Text = "Data Fetching";
            // 
            // lblBenchmarkDataInterval
            // 
            this.lblBenchmarkDataInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkDataInterval.AutoSize = true;
            this.lblBenchmarkDataInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkDataInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkDataInterval.LanguageFile = "";
            this.lblBenchmarkDataInterval.Location = new System.Drawing.Point(3, 26);
            this.lblBenchmarkDataInterval.Name = "lblBenchmarkDataInterval";
            this.lblBenchmarkDataInterval.Size = new System.Drawing.Size(91, 20);
            this.lblBenchmarkDataInterval.TabIndex = 13;
            this.lblBenchmarkDataInterval.Text = "Interval (ms)";
            // 
            // ntxtBenchmarkDataIterations
            // 
            this.ntxtBenchmarkDataIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkDataIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkDataIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkDataIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkDataIterations.Location = new System.Drawing.Point(118, 56);
            this.ntxtBenchmarkDataIterations.Name = "ntxtBenchmarkDataIterations";
            this.ntxtBenchmarkDataIterations.Number = 99999;
            this.ntxtBenchmarkDataIterations.ReadOnly = true;
            this.ntxtBenchmarkDataIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkDataIterations.TabIndex = 16;
            this.ntxtBenchmarkDataIterations.Text = "99999";
            // 
            // lblBenchmarkDataIterations
            // 
            this.lblBenchmarkDataIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkDataIterations.AutoSize = true;
            this.lblBenchmarkDataIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkDataIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkDataIterations.LanguageFile = "";
            this.lblBenchmarkDataIterations.Location = new System.Drawing.Point(3, 59);
            this.lblBenchmarkDataIterations.Name = "lblBenchmarkDataIterations";
            this.lblBenchmarkDataIterations.Size = new System.Drawing.Size(109, 20);
            this.lblBenchmarkDataIterations.TabIndex = 14;
            this.lblBenchmarkDataIterations.Text = "Iterations / sec.";
            // 
            // ntxtBenchmarkDataInterval
            // 
            this.ntxtBenchmarkDataInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkDataInterval.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkDataInterval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkDataInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkDataInterval.Location = new System.Drawing.Point(118, 23);
            this.ntxtBenchmarkDataInterval.Name = "ntxtBenchmarkDataInterval";
            this.ntxtBenchmarkDataInterval.Number = 99999;
            this.ntxtBenchmarkDataInterval.ReadOnly = true;
            this.ntxtBenchmarkDataInterval.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkDataInterval.TabIndex = 15;
            this.ntxtBenchmarkDataInterval.Text = "99999";
            // 
            // lblBenchmarkResourceIterations
            // 
            this.lblBenchmarkResourceIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkResourceIterations.AutoSize = true;
            this.lblBenchmarkResourceIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkResourceIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkResourceIterations.LanguageFile = "";
            this.lblBenchmarkResourceIterations.Location = new System.Drawing.Point(3, 59);
            this.lblBenchmarkResourceIterations.Name = "lblBenchmarkResourceIterations";
            this.lblBenchmarkResourceIterations.Size = new System.Drawing.Size(173, 20);
            this.lblBenchmarkResourceIterations.TabIndex = 19;
            this.lblBenchmarkResourceIterations.Text = "Resource Iterations / sec.";
            // 
            // lblBenchmarkMaphackIterations
            // 
            this.lblBenchmarkMaphackIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkMaphackIterations.AutoSize = true;
            this.lblBenchmarkMaphackIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkMaphackIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkMaphackIterations.LanguageFile = "";
            this.lblBenchmarkMaphackIterations.Location = new System.Drawing.Point(3, 290);
            this.lblBenchmarkMaphackIterations.Name = "lblBenchmarkMaphackIterations";
            this.lblBenchmarkMaphackIterations.Size = new System.Drawing.Size(173, 20);
            this.lblBenchmarkMaphackIterations.TabIndex = 34;
            this.lblBenchmarkMaphackIterations.Text = "Maphack Iterations / sec.";
            // 
            // lblBenchmarkArmyIterations
            // 
            this.lblBenchmarkArmyIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkArmyIterations.AutoSize = true;
            this.lblBenchmarkArmyIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkArmyIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkArmyIterations.LanguageFile = "";
            this.lblBenchmarkArmyIterations.Location = new System.Drawing.Point(3, 158);
            this.lblBenchmarkArmyIterations.Name = "lblBenchmarkArmyIterations";
            this.lblBenchmarkArmyIterations.Size = new System.Drawing.Size(148, 20);
            this.lblBenchmarkArmyIterations.TabIndex = 26;
            this.lblBenchmarkArmyIterations.Text = "Army Iterations / sec.";
            // 
            // lblBenchmarkProductiontabIterations
            // 
            this.lblBenchmarkProductiontabIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkProductiontabIterations.AutoSize = true;
            this.lblBenchmarkProductiontabIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkProductiontabIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkProductiontabIterations.LanguageFile = "";
            this.lblBenchmarkProductiontabIterations.Location = new System.Drawing.Point(3, 257);
            this.lblBenchmarkProductiontabIterations.Name = "lblBenchmarkProductiontabIterations";
            this.lblBenchmarkProductiontabIterations.Size = new System.Drawing.Size(210, 20);
            this.lblBenchmarkProductiontabIterations.TabIndex = 32;
            this.lblBenchmarkProductiontabIterations.Text = "ProductionTab Iterations / sec.";
            // 
            // lblBenchmarkUnittabIterations
            // 
            this.lblBenchmarkUnittabIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkUnittabIterations.AutoSize = true;
            this.lblBenchmarkUnittabIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkUnittabIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkUnittabIterations.LanguageFile = "";
            this.lblBenchmarkUnittabIterations.Location = new System.Drawing.Point(3, 224);
            this.lblBenchmarkUnittabIterations.Name = "lblBenchmarkUnittabIterations";
            this.lblBenchmarkUnittabIterations.Size = new System.Drawing.Size(165, 20);
            this.lblBenchmarkUnittabIterations.TabIndex = 30;
            this.lblBenchmarkUnittabIterations.Text = "UnitTab Iterations / sec.";
            // 
            // lblBenchmarkApmIterations
            // 
            this.lblBenchmarkApmIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkApmIterations.AutoSize = true;
            this.lblBenchmarkApmIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkApmIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkApmIterations.LanguageFile = "";
            this.lblBenchmarkApmIterations.Location = new System.Drawing.Point(3, 191);
            this.lblBenchmarkApmIterations.Name = "lblBenchmarkApmIterations";
            this.lblBenchmarkApmIterations.Size = new System.Drawing.Size(145, 20);
            this.lblBenchmarkApmIterations.TabIndex = 28;
            this.lblBenchmarkApmIterations.Text = "Apm Iterations / sec.";
            // 
            // lblBenchmarkWorkerIterations
            // 
            this.lblBenchmarkWorkerIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkWorkerIterations.AutoSize = true;
            this.lblBenchmarkWorkerIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkWorkerIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkWorkerIterations.LanguageFile = "";
            this.lblBenchmarkWorkerIterations.Location = new System.Drawing.Point(3, 125);
            this.lblBenchmarkWorkerIterations.Name = "lblBenchmarkWorkerIterations";
            this.lblBenchmarkWorkerIterations.Size = new System.Drawing.Size(161, 20);
            this.lblBenchmarkWorkerIterations.TabIndex = 24;
            this.lblBenchmarkWorkerIterations.Text = "Worker Iterations / sec.";
            // 
            // lblBenchmarkIncomeIterations
            // 
            this.lblBenchmarkIncomeIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkIncomeIterations.AutoSize = true;
            this.lblBenchmarkIncomeIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkIncomeIterations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkIncomeIterations.LanguageFile = "";
            this.lblBenchmarkIncomeIterations.Location = new System.Drawing.Point(3, 92);
            this.lblBenchmarkIncomeIterations.Name = "lblBenchmarkIncomeIterations";
            this.lblBenchmarkIncomeIterations.Size = new System.Drawing.Size(162, 20);
            this.lblBenchmarkIncomeIterations.TabIndex = 22;
            this.lblBenchmarkIncomeIterations.Text = "Income Iterations / sec.";
            // 
            // lblBenchmarkDrawingInterval
            // 
            this.lblBenchmarkDrawingInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBenchmarkDrawingInterval.AutoSize = true;
            this.lblBenchmarkDrawingInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkDrawingInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkDrawingInterval.LanguageFile = "";
            this.lblBenchmarkDrawingInterval.Location = new System.Drawing.Point(3, 26);
            this.lblBenchmarkDrawingInterval.Name = "lblBenchmarkDrawingInterval";
            this.lblBenchmarkDrawingInterval.Size = new System.Drawing.Size(91, 20);
            this.lblBenchmarkDrawingInterval.TabIndex = 18;
            this.lblBenchmarkDrawingInterval.Text = "Interval (ms)";
            // 
            // ntxtBenchmarkMaphackIterations
            // 
            this.ntxtBenchmarkMaphackIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkMaphackIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkMaphackIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkMaphackIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkMaphackIterations.Location = new System.Drawing.Point(219, 287);
            this.ntxtBenchmarkMaphackIterations.Name = "ntxtBenchmarkMaphackIterations";
            this.ntxtBenchmarkMaphackIterations.Number = 99999;
            this.ntxtBenchmarkMaphackIterations.ReadOnly = true;
            this.ntxtBenchmarkMaphackIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkMaphackIterations.TabIndex = 35;
            this.ntxtBenchmarkMaphackIterations.Text = "99999";
            // 
            // ntxtBenchmarkProductionTabIterations
            // 
            this.ntxtBenchmarkProductionTabIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkProductionTabIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkProductionTabIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkProductionTabIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkProductionTabIterations.Location = new System.Drawing.Point(219, 254);
            this.ntxtBenchmarkProductionTabIterations.Name = "ntxtBenchmarkProductionTabIterations";
            this.ntxtBenchmarkProductionTabIterations.Number = 99999;
            this.ntxtBenchmarkProductionTabIterations.ReadOnly = true;
            this.ntxtBenchmarkProductionTabIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkProductionTabIterations.TabIndex = 33;
            this.ntxtBenchmarkProductionTabIterations.Text = "99999";
            // 
            // ntxtBenchmarkUnitTabIterations
            // 
            this.ntxtBenchmarkUnitTabIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkUnitTabIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkUnitTabIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkUnitTabIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkUnitTabIterations.Location = new System.Drawing.Point(219, 221);
            this.ntxtBenchmarkUnitTabIterations.Name = "ntxtBenchmarkUnitTabIterations";
            this.ntxtBenchmarkUnitTabIterations.Number = 99999;
            this.ntxtBenchmarkUnitTabIterations.ReadOnly = true;
            this.ntxtBenchmarkUnitTabIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkUnitTabIterations.TabIndex = 31;
            this.ntxtBenchmarkUnitTabIterations.Text = "99999";
            // 
            // ntxtBenchmarkApmIterations
            // 
            this.ntxtBenchmarkApmIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkApmIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkApmIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkApmIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkApmIterations.Location = new System.Drawing.Point(219, 188);
            this.ntxtBenchmarkApmIterations.Name = "ntxtBenchmarkApmIterations";
            this.ntxtBenchmarkApmIterations.Number = 99999;
            this.ntxtBenchmarkApmIterations.ReadOnly = true;
            this.ntxtBenchmarkApmIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkApmIterations.TabIndex = 29;
            this.ntxtBenchmarkApmIterations.Text = "99999";
            // 
            // ntxtBenchmarkArmyIterations
            // 
            this.ntxtBenchmarkArmyIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkArmyIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkArmyIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkArmyIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkArmyIterations.Location = new System.Drawing.Point(219, 155);
            this.ntxtBenchmarkArmyIterations.Name = "ntxtBenchmarkArmyIterations";
            this.ntxtBenchmarkArmyIterations.Number = 99999;
            this.ntxtBenchmarkArmyIterations.ReadOnly = true;
            this.ntxtBenchmarkArmyIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkArmyIterations.TabIndex = 27;
            this.ntxtBenchmarkArmyIterations.Text = "99999";
            // 
            // ntxtBenchmarkWorkerIterations
            // 
            this.ntxtBenchmarkWorkerIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkWorkerIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkWorkerIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkWorkerIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkWorkerIterations.Location = new System.Drawing.Point(219, 122);
            this.ntxtBenchmarkWorkerIterations.Name = "ntxtBenchmarkWorkerIterations";
            this.ntxtBenchmarkWorkerIterations.Number = 99999;
            this.ntxtBenchmarkWorkerIterations.ReadOnly = true;
            this.ntxtBenchmarkWorkerIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkWorkerIterations.TabIndex = 25;
            this.ntxtBenchmarkWorkerIterations.Text = "99999";
            // 
            // ntxtBenchmarkIncomeIterations
            // 
            this.ntxtBenchmarkIncomeIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkIncomeIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkIncomeIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkIncomeIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkIncomeIterations.Location = new System.Drawing.Point(219, 89);
            this.ntxtBenchmarkIncomeIterations.Name = "ntxtBenchmarkIncomeIterations";
            this.ntxtBenchmarkIncomeIterations.Number = 99999;
            this.ntxtBenchmarkIncomeIterations.ReadOnly = true;
            this.ntxtBenchmarkIncomeIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkIncomeIterations.TabIndex = 23;
            this.ntxtBenchmarkIncomeIterations.Text = "99999";
            // 
            // ntxtBenchmarkResourceIterations
            // 
            this.ntxtBenchmarkResourceIterations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkResourceIterations.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkResourceIterations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkResourceIterations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkResourceIterations.Location = new System.Drawing.Point(219, 56);
            this.ntxtBenchmarkResourceIterations.Name = "ntxtBenchmarkResourceIterations";
            this.ntxtBenchmarkResourceIterations.Number = 99999;
            this.ntxtBenchmarkResourceIterations.ReadOnly = true;
            this.ntxtBenchmarkResourceIterations.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkResourceIterations.TabIndex = 21;
            this.ntxtBenchmarkResourceIterations.Text = "99999";
            // 
            // ntxtBenchmarkDrawingInterval
            // 
            this.ntxtBenchmarkDrawingInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ntxtBenchmarkDrawingInterval.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ntxtBenchmarkDrawingInterval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ntxtBenchmarkDrawingInterval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntxtBenchmarkDrawingInterval.Location = new System.Drawing.Point(219, 23);
            this.ntxtBenchmarkDrawingInterval.Name = "ntxtBenchmarkDrawingInterval";
            this.ntxtBenchmarkDrawingInterval.Number = 99999;
            this.ntxtBenchmarkDrawingInterval.ReadOnly = true;
            this.ntxtBenchmarkDrawingInterval.Size = new System.Drawing.Size(55, 27);
            this.ntxtBenchmarkDrawingInterval.TabIndex = 20;
            this.ntxtBenchmarkDrawingInterval.Text = "99999";
            // 
            // lblBenchmarkDrawing
            // 
            this.lblBenchmarkDrawing.AutoSize = true;
            this.lblBenchmarkDrawing.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchmarkDrawing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(90)))));
            this.lblBenchmarkDrawing.LanguageFile = "";
            this.lblBenchmarkDrawing.Location = new System.Drawing.Point(3, 0);
            this.lblBenchmarkDrawing.Name = "lblBenchmarkDrawing";
            this.lblBenchmarkDrawing.Size = new System.Drawing.Size(68, 20);
            this.lblBenchmarkDrawing.TabIndex = 17;
            this.lblBenchmarkDrawing.Text = "Drawing";
            // 
            // lstvCredits
            // 
            this.lstvCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvCredits.AutoArrange = false;
            this.lstvCredits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCreditsContributer,
            this.chCreditsReason});
            this.lstvCredits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvCredits.FullRowSelect = true;
            this.lstvCredits.GridLines = true;
            this.lstvCredits.Location = new System.Drawing.Point(15, 15);
            this.lstvCredits.Name = "lstvCredits";
            this.lstvCredits.Size = new System.Drawing.Size(1001, 425);
            this.lstvCredits.TabIndex = 24;
            this.lstvCredits.UseCompatibleStateImageBehavior = false;
            this.lstvCredits.View = System.Windows.Forms.View.Details;
            this.lstvCredits.SizeChanged += new System.EventHandler(this.lstvCredits_SizeChanged);
            // 
            // chCreditsContributer
            // 
            this.chCreditsContributer.Text = "Contributer";
            this.chCreditsContributer.Width = 250;
            // 
            // chCreditsReason
            // 
            this.chCreditsReason.Text = "But.. why?";
            this.chCreditsReason.Width = 769;
            // 
            // cpnlVarious
            // 
            this.cpnlVarious.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlVarious.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlVarious.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlVarious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlVarious.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlVarious.DisplayText = "Various";
            this.cpnlVarious.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlVarious.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlVarious.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlVarious.Icon")));
            this.cpnlVarious.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlVarious.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlVarious.IsClicked = false;
            this.cpnlVarious.IsHovering = false;
            this.cpnlVarious.Location = new System.Drawing.Point(0, 120);
            this.cpnlVarious.Name = "cpnlVarious";
            this.cpnlVarious.SettingsPanel = this.pnlVarious;
            this.cpnlVarious.Size = new System.Drawing.Size(152, 40);
            this.cpnlVarious.TabIndex = 2;
            this.cpnlVarious.TextSize = 11F;
            this.cpnlVarious.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlHelpMe
            // 
            this.cpnlHelpMe.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlHelpMe.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlHelpMe.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlHelpMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlHelpMe.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpnlHelpMe.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlHelpMe.DisplayText = "Help Me";
            this.cpnlHelpMe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlHelpMe.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlHelpMe.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlHelpMe.Icon")));
            this.cpnlHelpMe.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlHelpMe.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlHelpMe.IsClicked = false;
            this.cpnlHelpMe.IsHovering = false;
            this.cpnlHelpMe.Location = new System.Drawing.Point(0, 320);
            this.cpnlHelpMe.Name = "cpnlHelpMe";
            this.cpnlHelpMe.SettingsPanel = this.pnlHelpMe;
            this.cpnlHelpMe.Size = new System.Drawing.Size(152, 40);
            this.cpnlHelpMe.TabIndex = 7;
            this.cpnlHelpMe.TextSize = 11F;
            this.cpnlHelpMe.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlBenchmark
            // 
            this.cpnlBenchmark.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlBenchmark.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlBenchmark.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlBenchmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlBenchmark.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpnlBenchmark.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlBenchmark.DisplayText = "Benchmark";
            this.cpnlBenchmark.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlBenchmark.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlBenchmark.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlBenchmark.Icon")));
            this.cpnlBenchmark.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlBenchmark.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlBenchmark.IsClicked = false;
            this.cpnlBenchmark.IsHovering = false;
            this.cpnlBenchmark.Location = new System.Drawing.Point(0, 280);
            this.cpnlBenchmark.Name = "cpnlBenchmark";
            this.cpnlBenchmark.SettingsPanel = this.pnlBenchmark;
            this.cpnlBenchmark.Size = new System.Drawing.Size(152, 40);
            this.cpnlBenchmark.TabIndex = 6;
            this.cpnlBenchmark.TextSize = 11F;
            this.cpnlBenchmark.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlCredits
            // 
            this.cpnlCredits.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlCredits.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlCredits.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpnlCredits.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlCredits.DisplayText = "Credits";
            this.cpnlCredits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlCredits.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlCredits.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlCredits.Icon")));
            this.cpnlCredits.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlCredits.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlCredits.IsClicked = false;
            this.cpnlCredits.IsHovering = false;
            this.cpnlCredits.Location = new System.Drawing.Point(0, 240);
            this.cpnlCredits.Name = "cpnlCredits";
            this.cpnlCredits.SettingsPanel = this.pnlCredits;
            this.cpnlCredits.Size = new System.Drawing.Size(152, 40);
            this.cpnlCredits.TabIndex = 5;
            this.cpnlCredits.TextSize = 11F;
            this.cpnlCredits.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlDebug
            // 
            this.cpnlDebug.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlDebug.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlDebug.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlDebug.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpnlDebug.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlDebug.DisplayText = "Debug";
            this.cpnlDebug.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlDebug.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlDebug.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlDebug.Icon")));
            this.cpnlDebug.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlDebug.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlDebug.IsClicked = false;
            this.cpnlDebug.IsHovering = false;
            this.cpnlDebug.Location = new System.Drawing.Point(0, 200);
            this.cpnlDebug.Name = "cpnlDebug";
            this.cpnlDebug.SettingsPanel = this.pnlDebug;
            this.cpnlDebug.Size = new System.Drawing.Size(152, 40);
            this.cpnlDebug.TabIndex = 4;
            this.cpnlDebug.TextSize = 11F;
            this.cpnlDebug.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlApplication
            // 
            this.cpnlApplication.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlApplication.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlApplication.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlApplication.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlApplication.DisplayText = "Application";
            this.cpnlApplication.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlApplication.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlApplication.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlApplication.Icon")));
            this.cpnlApplication.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlApplication.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlApplication.IsClicked = false;
            this.cpnlApplication.IsHovering = false;
            this.cpnlApplication.Location = new System.Drawing.Point(0, 40);
            this.cpnlApplication.Name = "cpnlApplication";
            this.cpnlApplication.SettingsPanel = this.pnlApplication;
            this.cpnlApplication.Size = new System.Drawing.Size(152, 40);
            this.cpnlApplication.TabIndex = 0;
            this.cpnlApplication.TextSize = 11F;
            this.cpnlApplication.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlOverlays
            // 
            this.cpnlOverlays.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlOverlays.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlOverlays.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlOverlays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlays.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlOverlays.DisplayText = "Overlays";
            this.cpnlOverlays.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlOverlays.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlOverlays.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlOverlays.Icon")));
            this.cpnlOverlays.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlOverlays.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlOverlays.IsClicked = false;
            this.cpnlOverlays.IsHovering = false;
            this.cpnlOverlays.Location = new System.Drawing.Point(0, 80);
            this.cpnlOverlays.Name = "cpnlOverlays";
            this.cpnlOverlays.SettingsPanel = this.pnlOverlays;
            this.cpnlOverlays.Size = new System.Drawing.Size(152, 40);
            this.cpnlOverlays.TabIndex = 1;
            this.cpnlOverlays.TextSize = 11F;
            this.cpnlOverlays.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // cpnlPlugins
            // 
            this.cpnlPlugins.ActiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.cpnlPlugins.ActiveBorderPosition = AnotherSc2Hack.Classes.FrontEnds.Custom_Controls.ActiveBorderPosition.Left;
            this.cpnlPlugins.ActiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cpnlPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlPlugins.DisplayColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlPlugins.DisplayText = "Plugins";
            this.cpnlPlugins.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpnlPlugins.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.cpnlPlugins.Icon = ((System.Drawing.Image)(resources.GetObject("cpnlPlugins.Icon")));
            this.cpnlPlugins.InactiveBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.cpnlPlugins.InactiveForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.cpnlPlugins.IsClicked = false;
            this.cpnlPlugins.IsHovering = false;
            this.cpnlPlugins.Location = new System.Drawing.Point(0, 160);
            this.cpnlPlugins.Name = "cpnlPlugins";
            this.cpnlPlugins.SettingsPanel = this.pnlPlugins;
            this.cpnlPlugins.Size = new System.Drawing.Size(152, 40);
            this.cpnlPlugins.TabIndex = 3;
            this.cpnlPlugins.TextSize = 11F;
            this.cpnlPlugins.Click += new System.EventHandler(this.cpnl_Click);
            // 
            // NewMainHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 592);
            this.Controls.Add(this.pnlBottomStrip);
            this.Controls.Add(this.pnlMainArea);
            this.Controls.Add(this.pnlLeftSelection);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1196, 630);
            this.Name = "NewMainHandler";
            this.Text = "AnotherSc2Hack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewMainHandler_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewMainHandler_FormClosed);
            this.Load += new System.EventHandler(this.NewMainHandler_Load);
            this.Resize += new System.EventHandler(this.NewMainHandler_Resize);
            this.pnlLeftSelection.ResumeLayout(false);
            this.pnlVarious.ResumeLayout(false);
            this.pnlVarious.PerformLayout();
            this.tlpVariousContainer.ResumeLayout(false);
            this.tlpVariousContainer.PerformLayout();
            this.tlpVariousAlertContainer.ResumeLayout(false);
            this.tlpVariousAlertContainer.PerformLayout();
            this.tlpVariousWorkerCoachContainer.ResumeLayout(false);
            this.tlpVariousWorkerCoachContainer.PerformLayout();
            this.tlpVariousPersonalApmContainer.ResumeLayout(false);
            this.tlpVariousPersonalApmContainer.PerformLayout();
            this.pnlHelpMe.ResumeLayout(false);
            this.pnlHelpMe.PerformLayout();
            this.pnlBenchmark.ResumeLayout(false);
            this.pnlBenchmark.PerformLayout();
            this.tlpBenchmarkDataContainer.ResumeLayout(false);
            this.tlpBenchmarkDataContainer.PerformLayout();
            this.tlpBenchmarkDrawingContainer.ResumeLayout(false);
            this.tlpBenchmarkDrawingContainer.PerformLayout();
            this.pnlCredits.ResumeLayout(false);
            this.pnlDebug.ResumeLayout(false);
            this.pnlDebug.PerformLayout();
            this.pnlApplication.ResumeLayout(false);
            this.pnlApplication.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOverlays.ResumeLayout(false);
            this.pnlPanelContainer.ResumeLayout(false);
            this.pnlPanelContainer.PerformLayout();
            this.pnlPlugins.ResumeLayout(false);
            this.pnlPlugins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPluginsImages)).EndInit();
            this.cmPluginInstall.ResumeLayout(false);
            this.cmPluginRemove.ResumeLayout(false);
            this.pnlMainArea.ResumeLayout(false);
            this.pnlMainArea.PerformLayout();
            this.pnlBottomStrip.ResumeLayout(false);
            this.pnlBottomStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.ClickablePanel cpnlApplication;
        private Custom_Controls.ClickablePanel cpnlOverlays;
        private Custom_Controls.ClickablePanel cpnlPlugins;
        private System.Windows.Forms.Panel pnlLeftSelection;
        private System.Windows.Forms.Panel pnlMainArea;
        private System.Windows.Forms.Panel pnlApplication;
        private LanguageLabel lblTabname;
        private NumberTextBox ntxtGraphicsRefresh;
        private NumberTextBox ntxtMemoryRefresh;
        private LanguageLabel lblApplicationGraphicsRefresh;
        private LanguageLabel lblApplicationMemoryReading;
        private KeyTextBox ktxtReposition;
        private LanguageLabel lblApplicationReposition;
        private LanguageButton btnReposition;
        private AnotherCheckbox aChBxOnlyDrawInForeground;
        private Custom_Controls.ClickablePanel cpnlDebug;
        private System.Windows.Forms.ComboBox chBxLanguage;
        private LanguageLabel lblApplicationLanguage;
        private System.Windows.Forms.Panel pnlOverlays;
        private Custom_Controls.ClickablePanel cpnlOverlaysResources;
        private System.Windows.Forms.Panel pnlPanelContainer;
        private Custom_Controls.ClickablePanel cpnlOverlaysIncome;
        private Custom_Controls.ClickablePanel cpnlOverlaysProduction;
        private Custom_Controls.ClickablePanel cpnlOverlaysUnits;
        private Custom_Controls.ClickablePanel cpnlOverlaysMaphack;
        private Custom_Controls.ClickablePanel cpnlOverlaysApm;
        private Custom_Controls.ClickablePanel cpnlOverlaysArmy;
        private Custom_Controls.ClickablePanel cpnlOverlaysWorker;
        private Container.PanelOverlayBasics pnlOverlayResource;
        private Container.PanelOverlayBasics pnlOverlayIncome;
        private Container.PanelOverlayBasics pnlOverlayApm;
        private Container.PanelOverlayBasics pnlOverlayArmy;
        private Container.PanelOverlayWorker pnlOverlayWorker;
        private Container.PanelOverlayMaphack pnlOverlayMaphack;
        private Container.PanelOverlayUnittab pnlOverlayUnittab;
        private Container.PanelOverlayProductiontab pnlOverlayProductiontab;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.TextBox txtDebugPlayerMemory;
        private LanguageLabel lblDebugPlayerObjects;
        private LanguageLabel lblDebugPlayerLocation;
        private System.Windows.Forms.TextBox txtDebugPlayername;
        private LanguageLabel lblDebugPlayername;
        private LanguageButton btnDebugPlayerForward;
        private LanguageButton btnDebugPlayerBack;
        private LanguageLabel lblDebugPlayerdata;
        private System.Windows.Forms.TextBox txtDebugUnitMemory;
        private LanguageLabel lblDebugUnitObjects;
        private LanguageLabel lblDebugUnitLocation;
        private System.Windows.Forms.TextBox txtDebugUnitname;
        private LanguageLabel lblDebugUnitname;
        private LanguageButton btnDebugUnitForward;
        private LanguageButton btnDebugUnitBack;
        private LanguageLabel lblDebugUnitdata;
        private AnotherListview lstvDebugPlayderdata;
        private System.Windows.Forms.ColumnHeader chDebugPlayerDataAttribute;
        private System.Windows.Forms.ColumnHeader chDebugPlayerDataValue;
        private AnotherListview lstvDebugUnitdata;
        private System.Windows.Forms.ColumnHeader chDebugUnitDataAttribute;
        private System.Windows.Forms.ColumnHeader chDebugUnitDataValue;
        private NumberTextBox ntxtDebugUnitLocation;
        private NumberTextBox ntxtDebugPlayerLocation;
        private AnotherListview lstvDebugMapdata;
        private System.Windows.Forms.ColumnHeader chDebugMapDataAttribute;
        private System.Windows.Forms.ColumnHeader chDebugMapDataValue;
        private LanguageLabel lblDebugMapdata;
        private AnotherListview lstvDebugMatchdata;
        private System.Windows.Forms.ColumnHeader chDebugMatchDataAttribute;
        private System.Windows.Forms.ColumnHeader chDebugMatchDataValue;
        private LanguageLabel lblDebugMatchdata;
        private System.Windows.Forms.Panel pnlPlugins;
        private LanguageLabel lblPluginLoadedPlugins;
        private AnotherListview lstvPluginsLoadedPlugins;
        private System.Windows.Forms.ColumnHeader chPluginsLoadedPluginName;
        private System.Windows.Forms.ColumnHeader chPluginsLoadedPluginVersion;
        private AnotherListview lstvPluginsAvailablePlugins;
        private System.Windows.Forms.ColumnHeader chPluginsAvailablePluginName;
        private System.Windows.Forms.ColumnHeader chPluginsAvailablePluginVersion;
        private LanguageLabel lblPluginAvailablePlugins;
        private LanguageButton btnPluginsInstallPlugin;
        private LanguageLabel lblPluginsImageposition;
        private LanguageButton btnPluginsImagesNext;
        private LanguageButton btnPluginsImagesPrevious;
        private System.Windows.Forms.PictureBox pcbPluginsImages;
        private LanguageLabel lblPluginImages;
        private LanguageLabel lblPluginDescription;
        private System.Windows.Forms.RichTextBox rtbPluginsDescription;
        private System.Windows.Forms.ProgressBar pbMainProgress;
        private LanguageLabel lblApplicationGlobalSettings;
        private LanguageButton btnLaunchProduction;
        private LanguageButton btnLaunchUnit;
        private LanguageButton btnLaunchMaphack;
        private LanguageButton btnLaunchArmy;
        private LanguageButton btnLaunchApm;
        private LanguageButton btnLaunchWorker;
        private LanguageButton btnLaunchIncome;
        private LanguageButton btnLaunchResource;
        private System.Windows.Forms.ContextMenuStrip cmPluginRemove;
        private System.Windows.Forms.ToolStripMenuItem tsPluginRemove;
        private System.Windows.Forms.ContextMenuStrip cmPluginInstall;
        private System.Windows.Forms.ToolStripMenuItem tsPluginInstallPlugin;
        private System.Windows.Forms.Panel pnlBottomStrip;
        private Custom_Controls.ClickablePanel cpnlCredits;
        private System.Windows.Forms.Panel pnlCredits;
        private AnotherListview lstvCredits;
        private System.Windows.Forms.ColumnHeader chCreditsContributer;
        private System.Windows.Forms.ColumnHeader chCreditsReason;
        private Custom_Controls.ClickablePanel cpnlBenchmark;
        private System.Windows.Forms.Panel pnlHelpMe;
        private LanguageButton btnHelpMePostOnD3scene;
        private LanguageLabel lblHelpSuggestionsBug;
        private LanguageButton btnHelpMeEmailMe;
        private LanguageLabel lblHelpMeEmail;
        private LanguageButton btnHelpMeGithubIssues;
        private LanguageLabel lblHelpLocalize;
        private LanguageButton btnHelpMeLocalize;
        private LanguageLabel lblHelpMeBitcoin;
        private LanguageButton btnHelpMePaypal;
        private LanguageLabel lblHelpCash;
        private LanguageButton btnHelpMeCopyEmail;
        private LanguageButton btnHelpMeCopyBitcoin;
        private Custom_Controls.ClickablePanel cpnlHelpMe;
        private System.Windows.Forms.Panel pnlBenchmark;
        private NumberTextBox ntxtBenchmarkDataIterations;
        private NumberTextBox ntxtBenchmarkDataInterval;
        private LanguageLabel lblBenchmarkDataIterations;
        private LanguageLabel lblBenchmarkDataInterval;
        private LanguageLabel lblBenchmarkData;
        private NumberTextBox ntxtBenchmarkProductionTabIterations;
        private LanguageLabel lblBenchmarkProductiontabIterations;
        private NumberTextBox ntxtBenchmarkUnitTabIterations;
        private LanguageLabel lblBenchmarkUnittabIterations;
        private NumberTextBox ntxtBenchmarkApmIterations;
        private LanguageLabel lblBenchmarkApmIterations;
        private NumberTextBox ntxtBenchmarkArmyIterations;
        private LanguageLabel lblBenchmarkArmyIterations;
        private NumberTextBox ntxtBenchmarkWorkerIterations;
        private LanguageLabel lblBenchmarkWorkerIterations;
        private NumberTextBox ntxtBenchmarkIncomeIterations;
        private LanguageLabel lblBenchmarkIncomeIterations;
        private NumberTextBox ntxtBenchmarkResourceIterations;
        private NumberTextBox ntxtBenchmarkDrawingInterval;
        private LanguageLabel lblBenchmarkResourceIterations;
        private LanguageLabel lblBenchmarkDrawingInterval;
        private LanguageLabel lblBenchmarkDrawing;
        private NumberTextBox ntxtBenchmarkMaphackIterations;
        private LanguageLabel lblBenchmarkMaphackIterations;
        private Custom_Controls.ClickablePanel cpnlVarious;
        private System.Windows.Forms.Panel pnlVarious;
        private NumberTextBox ntxtVariousApmLimit;
        private AnotherCheckbox aChBxVariousPersonalApmAlert;
        private AnotherCheckbox aChBxVariousShowPersonalApm;
        private LanguageLabel lblVariousPersonalApm;
        private AnotherCheckbox aChBxVariousShowPersonalClock;
        private LanguageLabel lblVariousPersonalClock;
        private AnotherCheckbox aChBxVariousWorkerCoach;
        private LanguageLabel lblVariousWorkerCoach;
        private NumberTextBox ntxtVariousWorkerCoachDisableAfter;
        private LanguageLabel lblVariousDisableAfter;
        private LanguageButton btnRestoreSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser wbNews;
        private AnotherCheckbox aChBxShowWebContent;
        private LanguageButton btnAdjustPanels;
        private System.Windows.Forms.TableLayoutPanel tlpVariousContainer;
        private System.Windows.Forms.TableLayoutPanel tlpVariousPersonalApmContainer;
        private System.Windows.Forms.TableLayoutPanel tlpVariousWorkerCoachContainer;
        private System.Windows.Forms.TableLayoutPanel tlpBenchmarkDrawingContainer;
        private System.Windows.Forms.TableLayoutPanel tlpBenchmarkDataContainer;
        private AnotherCheckbox aChBxVariousShowAlerts;
        private LanguageLabel lblVariousAlerts;
        private System.Windows.Forms.TableLayoutPanel tlpVariousAlertContainer;
        private LanguageLabel lblVariousShowAlert;
        private NumberTextBox ntxtVariousAlertShowDuration;
        private AnotherCheckbox aChBxVariousAlertSoundNotification;
        private LanguageButton btnVariousOpenAlerts;
    }
}