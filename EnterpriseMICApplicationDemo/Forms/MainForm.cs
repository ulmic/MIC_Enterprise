using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YO_APP_FULL;
using serializ2;

namespace EnterpriseMICApplicationDemo {
    public partial class MainForm : Form {

        /// <summary>
        /// Controls on main form
        /// </summary>
        private List<FunctionPanel> functions;
        private OpacityLabel[] optionLabels = new OpacityLabel[0];
        private DisComboBox chooseComboBox;
        private IndentionControlTextBox mailAdressDisTextBox;
        private DisTextBox[] inputText = new DisTextBox[0];
        private MyPressReleaseControl HTMLWorkSpace = new MyPressReleaseControl();
        private Card[] ideasCards;
        private Card[] tasksCards;
        private ListBox[] memberList;
        private MemberCard memberCard;
        private Button addToSendListButton;
        private AddToSendListNewItem addNewItem;

        /// <summary>
        /// Height row in impose of main form
        /// </summary>
        private const int rowHeight = 25;

        /// <summary>
        /// Widht column in impose of main form
        /// </summary>
        private const int columnWidth = 300;

        /// <summary>
        /// Indent on X-coordinate
        /// </summary>
        private const int indentX = 30;

        /// <summary>
        /// Yo Class in Enterprise MIC Application
        /// </summary>
        public YO_APP_FULL.YO_class yo;

        #region Initialization controls of main form

        #region Initialization main components

        public MainForm(int userIndex) {
            Login login = new Login();
            if ( login.CheckEnter() == Const.THEREISNOT ) {
                Program.LoginForm = new LoginForm();
                Program.LoginForm.Show();
            } else {
                Initialization(login.CheckEnter());
            }
        }

        private void PutControlsInBottomTableLayoutPanel() {
            this.bottomTableLayoutPanel.RowCount = 1;
            this.bottomTableLayoutPanel.ColumnCount = 2;
            this.bottomTableLayoutPanel.Dock = DockStyle.Fill;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.bottomTableLayoutPanel.Controls.Add(messageLabel, 0, 0);
            this.bottomTableLayoutPanel.Controls.Add(bottomButton, 1, 0);
        }

        private void InitAfterLoad() {
            bottomButton.Visible = false;
        }

        private void InitPanels() {
            functions = new List<FunctionPanel>();
            for ( int i = 0; i < Const.FUNCTIONS_COUNT; i++ ) {
                if ( Program.Data.MainUser.Functions[i] ) {
                    functions.Add(new FunctionPanel());
                }
            }
            InitViewUserDataPanel();
            InitDeliveryPanel();
            InitOnlineConferencePanel();
            this.leftFunctionPanel.TableBorderStyle = BorderStyle.None;
            this.leftFunctionPanel.InitializeCellsCount(1, functions.Count);
            this.leftFunctionPanel.Controls.AddRange(functions.ToArray<FunctionPanel>());
        }

        private void InitViewUserDataPanel() {
            nameLinkLabel.Indent = OpacityLinkLabel.ControlIndent.Small;
            postLabel.Indent = OpacityLabel.ControlIndent.Small;
            if ( Program.Data.MainUser.Functions[Const.VIEW_USER_DATA] ) {
                /* Быдло */
                functions[Const.VIEW_USER_DATA].InitializeCellsCount(1, 2);
                functions[Const.VIEW_USER_DATA].Controls.Add(this.nameLinkLabel, 0, 0);
                functions[Const.VIEW_USER_DATA].Controls.Add(this.postLabel, 0, 1);
                functions[Const.VIEW_USER_DATA].Size = new System.Drawing.Size(213, 83);
                functions[Const.VIEW_USER_DATA].TabIndex = 0;
            }
            functions[Const.VIEW_USER_DATA].ReverseControls();
        }

        private void InitDeliveryPanel() {
            //deliveryLinkLabel.EnumControlIndent = OpacityLinkLabel.EnumControlIndent.FirstOfList;
            deliveryListLinkLabel.Indent = OpacityLinkLabel.ControlIndent.FirstOfList;
            //deliveryNumberLinkLabel.EnumControlIndent = OpacityLinkLabel.EnumControlIndent.FirstOfList;
            deliveryNumberListLinkLabel.Indent = OpacityLinkLabel.ControlIndent.FirstOfList;
            if ( Program.Data.MainUser.Functions[Const.CREATE_NEW_DELIVERY] ) {
                /* Быдло */
                functions[Const.CREATE_NEW_DELIVERY].InitializeCellsCount(2, 3);
                //functions[Const.CREATE_NEW_DELIVERY].Controls.Add(this.deliveryLinkLabel, 0, 0);
                functions[Const.CREATE_NEW_DELIVERY].Controls.Add(this.deliveryListLinkLabel, 0, 0);
                //functions[Const.CREATE_NEW_DELIVERY].Controls.Add(this.deliveryNumberLinkLabel, 1, 0);
                functions[Const.CREATE_NEW_DELIVERY].Controls.Add(this.deliveryNumberListLinkLabel, 1, 0);
                functions[Const.CREATE_NEW_DELIVERY].Controls.Add(this.deliveryNewButton, 0, 1);
                functions[Const.CREATE_NEW_DELIVERY].Size = new System.Drawing.Size(200, 91);
                functions[Const.CREATE_NEW_DELIVERY].TabIndex = 1;
            }
        }

        //private void InitPlannerPanel() {
        //  if (Program.Data.MainUser.Functions[Const.ONLINE_CONFERENCE]) {
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(taskLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(taskListLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(eventLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(eventListLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(ideasLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(ideasListLinkLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(newIdeaButton);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(newIdeaLabel);
        //    functions[Const.ONLINE_CONFERENCE].Controls.Add(newIdeaTextBox);
        //    functions[Const.ONLINE_CONFERENCE].Dock = System.Windows.Forms.DockStyle.Top;
        //    functions[Const.ONLINE_CONFERENCE].Size = new Size(213, 203);
        //    functions[Const.ONLINE_CONFERENCE].TabIndex = 2;
        //  }
        //  Program.Data.InitMinds();
        //  ideasListLinkLabel.Text = Program.Data.IdeasCount.ToString();
        //  taskListLinkLabel.Text = Program.Data.TasksCount.ToString();
        //}

        private void InitOnlineConferencePanel() {
            OpacityLabel onlineConferenceLabel = new OpacityLabel();
            onlineConferenceLabel.Size = new Size(200, 40);
            onlineConferenceLabel.Indent = OpacityLabel.ControlIndent.Small;
            onlineConferenceLabel.TextAlign = ContentAlignment.MiddleCenter;
            onlineConferenceLabel.Text = "Онлайн-конференция руководителей Молодёжного инициативного центра";
            onlineConferenceLabel.MouseEnter += new EventHandler(onlineConferenceLabel_MouseEnter);
            if ( Program.Data.MainUser.Functions[Const.ONLINE_CONFERENCE] ) {
                functions[Const.ONLINE_CONFERENCE].InitializeCellsCount(1, 2);
                functions[Const.ONLINE_CONFERENCE].Controls.Add(onlineConferenceLabel, 0, 0);
                functions[Const.ONLINE_CONFERENCE].Controls.Add(this.onlineConferenceButton, 0, 1);
            }
        }

        private void onlineConferenceLabel_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Приватная онлайн-конференция руководителей Молодёжного инициативного центра");
        }

        public void Initialization(int userIndex) {
            Program.Data.InitUser(userIndex);
            InitializeComponent();
            this.Disposed += new EventHandler(MainForm_Disposed);

            nameLinkLabel.Text = Program.Data.MainUser.Name;
            postLabel.Text = Program.Data.MainUser.Post;

            nameLinkLabel.MouseEnter += new EventHandler(nameLinkLabel_MouseEnter);
            bottomButton.MouseEnter += new EventHandler(bottomButton_MouseEnter);
            deliveryLinkLabel.MouseEnter += new EventHandler(deliveryLinkLabel_MouseEnter);
            deliveryNumberLinkLabel.MouseEnter += new EventHandler(deliveryLinkLabel_MouseEnter);
            deliveryListLinkLabel.MouseEnter += new EventHandler(deliveryListLinkLabel_MouseEnter);
            deliveryNumberListLinkLabel.MouseEnter += new EventHandler(deliveryListLinkLabel_MouseEnter);
            deliveryNewButton.MouseEnter += new EventHandler(deliveryNewButton_MouseEnter);

            ideasLinkLabel.Click += new EventHandler(ideasLinkLabel_Click);
            ideasListLinkLabel.Click += new EventHandler(ideasLinkLabel_Click);
            newIdeaButton.Click += new EventHandler(newIdeaButton_Click);
            ideasLinkLabel.MouseEnter += new EventHandler(ideasLinkLabel_MouseEnter);
            ideasListLinkLabel.MouseEnter += new EventHandler(ideasLinkLabel_MouseEnter);
            newIdeaButton.MouseEnter += new EventHandler(newIdeaButton_MouseEnter);
            newIdeaTextBox.MouseEnter += new EventHandler(newIdeaTextBox_MouseEnter);
            newIdeaLabel.MouseEnter += new EventHandler(newIdeaButton_MouseEnter);

            taskLinkLabel.Click += new EventHandler(taskLinkLabel_Click);
            taskListLinkLabel.Click += new EventHandler(taskLinkLabel_Click);

            messageLabel.PutMessage("Добро пожаловать в рабочую область!");
            workSpaceTableLayoutPanel.Size = new Size(this.ClientSize.Width - leftFunctionPanel.Size.Width, this.ClientSize.Height - messageLabel.Height - 50);
            InitAfterLoad();
            InitPanels();
            workSpaceTableLayoutPanel.ReverseGradient = true;
            /* По умолчанию открываются задачи */
            viewUserData();

            deliveryNumberListLinkLabel.Text = Program.Data.GetNumberOfSendLists().ToString();
            deliveryListLinkLabel.Click += new EventHandler(deliveryListLinkLabel_Click);

            PutControlsInBottomTableLayoutPanel();
        }

        private void taskLinkLabel_Click(object sender, EventArgs e) {
            viewTasks();
        }

        private void newIdeaTextBox_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Введите текст новой идеи");
        }

        private void newIdeaButton_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Нажмите, чтобы добавить новые идеи");
        }

        private void ideasLinkLabel_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Посмотрите сохранённые идеи");
        }

        private void PutStyleTitleLabels(ref OpacityLabel t) {
            t.TextAlign = ContentAlignment.BottomCenter;
            t.Font = new Font(t.Font.FontFamily, t.Font.Size, FontStyle.Bold);
        }

        #endregion

        #region ClickEvents

        private void ideasLinkLabel_Click(object sender, EventArgs e) {
            viewIdeas();
        }

        private void newIdeaButton_Click(object sender, EventArgs e) {
            if ( newIdeaTextBox.NotDisText == false ) {
                messageLabel.PutMessage("Введите текст новой идеи", Const.BAD_MESSAGE);
                return;
            }
            if ( Program.Data.AnyMindEqual(newIdeaTextBox.Text, Const.IDEA) ) {
                messageLabel.PutMessage("Такая идея уже есть", Const.BAD_MESSAGE);
                return;
            }
            Program.Data.AddMind(newIdeaTextBox.Text, Const.IDEA);
            viewIdeas();
        }

        private void bottomButtonAddTask(object sender, EventArgs e) {
            addNewCardsToBoard(ref tasksCards, new Card[] { new Card() });
        }

        private void addNewCardsToBoard(ref Card[] cards, Card[] newCards) {
            for ( int i = 0; i < newCards.Length; i++ ) {
                newCards[i].Font = new Font(newCards[i].Font.FontFamily, 12F);
                newCards[i].Status = Card.Action.Edit;
            }
            List<Card> temp = tasksCards.ToList<Card>();
            temp.AddRange(newCards);
            tasksCards = temp.ToArray();
            cards = cards.Reverse<Card>().ToArray<Card>();
            for ( int i = 0; i < cards.Length; i++ ) {
                //cards[i].Location = addaptLocation(cards[i], i);
            }
            this.workSpaceTableLayoutPanel.Controls.AddRange(cards);
        }

        #endregion

        #region MouseEnter Events

        private void deliveryNewButton_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Сделать новую рассылку");
        }

        private void deliveryListLinkLabel_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Посмотреть и отредактировать списки рассылок");
        }

        private void deliveryLinkLabel_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Посмотреть все рассылки, сделанные Вами");
        }

        private void bottomButton_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Войти в новый профиль члена Молодёжного инициативного центра");
        }

        private void nameLinkLabel_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Посмореть базу данных членов Молодёжного инициативного центра");
        }

        private void deliveryThemeMouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Тема рассылки");
        }

        private void chooseComboBox_MouseEnter(object sender, EventArgs e) {
            messageLabel.PutMessage("Сохранённые списки рассылок");
        }

        #endregion

        public void Clear() {
            this.Controls.Clear();
        }

        #endregion

        #region CreateWorkSpaceControls

        #region Initialization Controls Functions

        private void initOptions(ref Card[] con) {
            for ( int i = 0; i < con.Length; i++ ) {
                con[i] = new Card();
                //con[i].Location = addaptLocation(con[i], i);
                con[i].Font = new Font(this.Font.FontFamily, 12F);
                con[i].Visible = true;
            }
        }

        private void initOptions(ref OpacityLabel[] con) {
            for ( int i = 0; i < con.Length; i++ ) {
                con[i] = new OpacityLabel();
                con[i].AutoSize = true;
                con[i].Dock = DockStyle.Fill;
                con[i].TextAlign = ContentAlignment.MiddleCenter;
                con[i].Font = new Font(this.Font.FontFamily, 12F);
                con[i].Visible = true;
            }
        }

        private void initOptions(ref DisComboBox con, int column, int row) {
            con = new DisComboBox {
                Size = new Size(columnWidth * 2, rowHeight),
                Font = new Font(this.Font.FontFamily, 12F),
                Visible = true
            };
        }

        private void initOptions(ref DisTextBox[] con, int column, int beginRow) {
            for ( int i = 0; i < con.Length; i++ ) {
                con[i] = new DisTextBox {
                    Size = new Size(columnWidth * 2, rowHeight),
                    Font = new Font(this.Font.FontFamily, 12F),
                    Visible = true
                };
            }
        }

        private void initOptions(ref MyPressReleaseControl con, int beginColumn, int beginRow) {
            con = new MyPressReleaseControl {
                Dock = DockStyle.Fill,
                Font = new Font(this.Font.FontFamily, 12F),
                Visible = true
            };
        }

        private void initOptions(ref ListBox[] con) {
            for ( int i = 0; i < con.Length; i++ ) {
                con[i] = new ListBox() {
                    Margin = new System.Windows.Forms.Padding(5),
                    Dock = DockStyle.Fill,
                    Font = new Font(this.Font.FontFamily, 12F),
                    Visible = true
                };
            }
        }

        #endregion

        private int cardsCountInForm(Card card) {
            return ( this.Width / ( card.Width + indentX ) );
        }

        #endregion

        #region Main Functions

        #region ViewUserData Function

        private void nameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            workSpaceTableLayoutPanel.Controls.Clear();
            viewUserData();
        }

        private void viewUserData() {
            Button chooseUserButton = bottomButton;
            chooseUserButton.Text = Const.BOTTOM_BUTTON_VIEW;
            chooseUserButton.Click += new EventHandler(bottomButtonViewUserData);
            chooseUserButton.Visible = true;
            this.bottomTableLayoutPanel.Controls.Add(chooseUserButton, 1, 0);
            this.workSpaceTableLayoutPanel.InitializeCellsCount(3, 3);

            this.workSpaceTableLayoutPanel.ColumnStyles.Insert(0, new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, columnWidth));
            this.workSpaceTableLayoutPanel.ColumnStyles.Insert(1, new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, columnWidth));
            this.workSpaceTableLayoutPanel.ColumnStyles.Insert(2, new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, Const.MEMBERCARD_SIZE));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(0, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, rowHeight * 3));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(1, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, rowHeight));

            optionLabels = new OpacityLabel[5];
            initOptions(ref optionLabels);
            optionLabels[Const.FULL_NAME_VIEW].Text = Program.Data.MainUser.FullName;
            optionLabels[Const.POST_VIEW].Text = Program.Data.MainUser.Post + " " + Const.FULL_MIC_GENITIVE;
            optionLabels[Const.TITLE_LISTBOX_LOCALS].Text = "Местные отделения";
            optionLabels[Const.TITLE_LISTBOX_MEMBERS].Text = "Члены местного отделения";
            optionLabels[Const.TITLE_MEMBERCARD].Text = "Карта члена МИЦ";
            optionLabels[Const.FULL_NAME_VIEW].BorderStyle = BorderStyle.FixedSingle;
            optionLabels[Const.POST_VIEW].BorderStyle = BorderStyle.FixedSingle;
            PutStyleTitleLabels(ref optionLabels[Const.TITLE_LISTBOX_LOCALS]);
            PutStyleTitleLabels(ref optionLabels[Const.TITLE_LISTBOX_MEMBERS]);
            PutStyleTitleLabels(ref optionLabels[Const.TITLE_MEMBERCARD]);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.POST_VIEW], 0, 0);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.FULL_NAME_VIEW], 0, 0);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.TITLE_MEMBERCARD], 0, 1);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.TITLE_LISTBOX_MEMBERS], 0, 1);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.TITLE_LISTBOX_LOCALS], 0, 1);

            memberList = new ListBox[2];
            initOptions(ref memberList);
            memberList[Const.LOCALS].Click += new EventHandler(MainForm_Click);
            memberList[Const.LOCALS].MouseLeave += MainForm_MouseLeave;
            memberList[Const.MEMBERS].Click += new EventHandler(GetMemberClick);
            memberList[Const.MEMBERS].MouseLeave += MainForm_MouseLeave;
            this.workSpaceTableLayoutPanel.Controls.Add(memberList[Const.LOCALS], 0, 2);
            this.workSpaceTableLayoutPanel.Controls.Add(memberList[Const.MEMBERS], 1, 2);

            PutInLocalsListBox();
        }

        void MainForm_MouseLeave(object sender, EventArgs e) {
            workSpaceTableLayoutPanel.needPaint = true;
        }

        private void bottomButtonViewUserData(object sender, EventArgs e) {
            Login login = new Login();
            Program.LoginForm = new LoginForm();
            Program.LoginForm.ReLogin = true;
            Program.LoginForm.Show();
        }

        private void PutInLocalsListBox() {
            string[] locals = Program.Data.GetMICLocals();
            memberList[Const.LOCALS].BeginUpdate();
            for ( int i = 0; i < locals.Length; i++ ) {
                memberList[Const.LOCALS].Items.Add(locals[i]);
            }
            memberList[Const.LOCALS].EndUpdate();
        }

        private void GetMemberClick(object sender, EventArgs e) {
            if ( memberList[Const.MEMBERS].SelectedItem != null ) {
                Member member = new Member();
                member = Program.Data.GetMICMember(Int32.Parse(memberList[Const.MEMBERS].SelectedItem.ToString().Split(' ')[0]));
                int index = this.workSpaceTableLayoutPanel.Controls.IndexOf(memberCard);
                if ( index == -1 ) {
                    memberCard = new MemberCard();
                    memberCard.PutMember(member);
                    this.workSpaceTableLayoutPanel.Controls.Add(memberCard, 2, 2);
                } else {
                    ( (MemberCard)this.workSpaceTableLayoutPanel.Controls[index] ).ChangeMember(member);
                }
            }
        }

        private void MainForm_Click(object sender, EventArgs e) {
            workSpaceTableLayoutPanel.needPaint = false; // становиться true в событии mouseleave
            PutInMemberListBox(memberList[Const.LOCALS].SelectedIndex);            
        }

        private void PutInMemberListBox(int index) {
            memberList[Const.MEMBERS].BeginUpdate();
            memberList[Const.MEMBERS].Items.Clear();
            string[] members = Program.Data.GetMICMembersByLocal(memberList[Const.LOCALS].Items[index].ToString());
            for ( int i = 0; i < members.Length; i++ ) {
                memberList[Const.MEMBERS].Items.Add(members[i]);
            }
            memberList[Const.MEMBERS].EndUpdate();
        }

        public void PutInMemberListBoxSameCityMembers(List<string> members) {
            memberList[Const.MEMBERS].Items.Clear();
            memberList[Const.MEMBERS].Items.AddRange(members.ToArray<string>());
        }

        public void PutInMembersListBoxSameBDateMembers(List<string> members) {
            memberList[Const.MEMBERS].Items.Clear();
            memberList[Const.MEMBERS].Items.AddRange(members.ToArray<string>());
        }

        public void PutInMembersListBoxSameEnterDateMembers(List<string> members) {
            memberList[Const.MEMBERS].Items.Clear();
            memberList[Const.MEMBERS].Items.AddRange(members.ToArray<string>());
        }

        public void PutInMemberCardGodFather(Member godFather) {
            this.workSpaceTableLayoutPanel.Controls.Remove(memberCard);
            memberCard = new MemberCard();
            memberCard.PutMember(godFather);
            this.workSpaceTableLayoutPanel.Controls.Add(memberCard, 2, 2);
        }

        #endregion

        #region Cards Functions

        private void viewIdeas() {
            bottomButton.Visible = false;
            workSpaceTableLayoutPanel.Controls.Clear();
            Program.Data.InitIdeas();
            ideasCards = new Card[Program.Data.IdeasCount];
            initOptions(ref ideasCards);
            ideasCards = ideasCards.Reverse<Card>().ToArray<Card>();
            for ( int i = 0; i < Program.Data.IdeasCount; i++ ) {
                ideasCards[i].Text = Program.Data.IdeaTextAt(i);
                ideasCards[i].HaveDate = Const.NO;
                ideasCards[i].CloseCard += new EventHandler(AnyCardClosed);
                ideasCards[i].HaveTitle = Const.NO;
                ideasCards[i].SaveText += new EventHandler(IdeasCards_SaveText);
            }
            workSpaceTableLayoutPanel.Controls.AddRange(ideasCards);
        }

        private void IdeasCards_SaveText(object sender, EventArgs e) {
            exportIdeas();
        }

        private void viewTasks() {
            Button addTaskButton = bottomButton;
            addTaskButton.Visible = true;
            addTaskButton.Text = Const.BOTTOM_BUTTON_ADD_TASK;
            addTaskButton.Click += new EventHandler(bottomButtonAddTask);
            this.bottomTableLayoutPanel.Controls.Add(addTaskButton);
            workSpaceTableLayoutPanel.Controls.Clear();
            Program.Data.InitTasks();
            tasksCards = new Card[Program.Data.TasksCount];
            initOptions(ref tasksCards);
            tasksCards = tasksCards.Reverse<Card>().ToArray<Card>();
            for ( int i = 0; i < tasksCards.Length; i++ ) {
                tasksCards[i].Text = Program.Data.TasksTextAt(i);
                tasksCards[i].HaveDate = Const.YES;
                tasksCards[i].CloseCard += new EventHandler(AnyCardClosed);
                tasksCards[i].SaveText += new EventHandler(TasksCards_SaveText);
            }
            workSpaceTableLayoutPanel.Controls.AddRange(tasksCards);
        }

        private void TasksCards_SaveText(object sender, EventArgs e) {
            exportTasks();
        }

        private void AnyCardClosed(object sender, EventArgs e) {
            for ( int i = 0; i < ideasCards.Length; i++ ) {
                if ( ideasCards[i].Close ) {
                    List<Card> temp = ideasCards.ToList<Card>();
                    temp.RemoveAt(i);
                    ideasCards = temp.ToArray();
                    Program.Data.RemoveIdeaAt(i);
                    break;
                }
            }
            for ( int i = 0; i < ideasCards.Length; i++ ) {
                //ideasCards[i].Location = addaptLocation(ideasCards[i], i);
            }
        }

        private string[] getMindsFromCards(Card[] cards) {
            if ( cards == null ) {
                return null;
            }
            string[] export = new string[cards.Length];
            for ( int i = 0; i < cards.Length; i++ ) {
                export[i] = cards[i].Text;
            }
            return export;
        }

        private void exportTasks() {
            Program.Data.SaveTasks(getMindsFromCards(tasksCards));
        }

        private void exportIdeas() {
            Program.Data.SaveIdeas(getMindsFromCards(ideasCards));
        }

        private void MainForm_Disposed(object sender, EventArgs e) {
            exportIdeas();
            exportTasks();
        }

        #endregion

        #region Deliveries

        #region CreateNewDelivery

        private void button1_Click(object sender, EventArgs e) {
            workSpaceTableLayoutPanel.Controls.Clear();
            createNewDelivery(Const.LIST_DELIVERY);
        }

        private void createNewDelivery(int deliveryType) {
            Button sendDeliveryButton = bottomButton;
            sendDeliveryButton.Visible = true;
            sendDeliveryButton.Text = Const.BOTTOM_BUTTON_CREATE_NEW_DELIVERY;
            sendDeliveryButton.Click -= new EventHandler(bottomButtonViewUserData);
            sendDeliveryButton.Click += new EventHandler(bottomButtonSendDelivery);
            this.bottomTableLayoutPanel.Controls.Add(sendDeliveryButton, 1, 0);

            this.workSpaceTableLayoutPanel.InitializeCellsCount(1, 3);
            this.workSpaceTableLayoutPanel.RowStyles.Insert(0, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, rowHeight));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(1, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, rowHeight));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(2, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

            if ( deliveryType == Const.LIST_DELIVERY ) {
                initOptions(ref chooseComboBox, 0, 0);
                chooseComboBox.Indent = DisComboBox.ControlIndent.Big;
                chooseComboBox.MouseEnter += new EventHandler(chooseComboBox_MouseEnter);
                chooseComboBox.DisText = "Сохранённые списки";
                chooseComboBox.Items.AddRange(Program.Data.GetAllSendLists());
                this.workSpaceTableLayoutPanel.Controls.Add(chooseComboBox, 0, 0);
            }
            if ( deliveryType == Const.ONCE_MAIL ) {
                mailAdressDisTextBox = new IndentionControlTextBox();
                mailAdressDisTextBox.Text = "E-mail адрес получателя";
                mailAdressDisTextBox.Dock = DockStyle.Fill;
                mailAdressDisTextBox.Indent = IndentionControlTextBox.ControlIndent.Big;
                mailAdressDisTextBox.Font = new Font(this.Font.FontFamily, 12F);
                this.workSpaceTableLayoutPanel.Controls.Add(mailAdressDisTextBox, 0, 0);
            }

            inputText = new DisTextBox[1]; // badcode
            initOptions(ref inputText, 0, 1);
            inputText[0].DisText = "Тема рассылки:";
            inputText[0].MouseEnter += new EventHandler(deliveryThemeMouseEnter);
            inputText[0].Indent = DisTextBox.ControlIndent.Big;
            this.workSpaceTableLayoutPanel.Controls.Add(inputText[0]);

            initOptions(ref HTMLWorkSpace, 0, 2);
            HTMLWorkSpace.Indent = MyPressReleaseControl.ControlIndent.Big;
            this.workSpaceTableLayoutPanel.Controls.Add(HTMLWorkSpace, 0, 2);
        }


        private void bottomButtonSendDelivery(object sender, EventArgs e) {
            yo = new YO_class();
            yo.ThereIsExceptions += new YO_class.EventHandler(yo_ThereIsExceptions);
            HTMLWorkSpace.setTextNoTags(yo.pasteLetter(HTMLWorkSpace.getTextNoTags().Split(' ')));
            SendMail sendMail = new SendMail();
            if ( this.workSpaceTableLayoutPanel.Controls.Contains(chooseComboBox) ) {
                SendingLists sendLists = new SendingLists();
                List<string> emails = sendLists.getEmails(chooseComboBox.SelectedItem.ToString());
                foreach ( string email in emails ) {
                    //sendMail.Send(email, HTMLWorkSpace.Text, Program.Data.MainUser.Email, Program.Data.MainUser.EmailPassword);
                }
            }
            if ( this.workSpaceTableLayoutPanel.Controls.Contains(mailAdressDisTextBox) ) {
                //sendMail.Send(mailAdressDisTextBox.Text, HTMLWorkSpace.Text, Program.Data.MainUser.Email, Program.Data.MainUser.EmailPassword);
            }
            throw new NotImplementedException();
        }

        private void yo_ThereIsExceptions(object sender, EventArgs e) {
            HTMLWorkSpace.setTextNoTags(yo.PasteLetterYOInExceptions(HTMLWorkSpace.getTextNoTags()));
        }

        public string GetTextFromHtmlEditor() {
            return this.HTMLWorkSpace.textForSend();
        }

        public void SetTextFromHtmlEditor(string text) {
            this.HTMLWorkSpace.setTextNoTags(text);
        }

        #endregion

        #region Delivery Send Lists

        private void deliveryListLinkLabel_Click(object sender, EventArgs e) {
            workSpaceTableLayoutPanel.Controls.Clear();
            viewSendLists();
        }

        private void viewSendLists() {
            optionLabels = new OpacityLabel[2];
            initOptions(ref optionLabels);
            PutStyleTitleLabels(ref optionLabels[Const.TITLE_LISTBOX_SENDLISTS]);
            PutStyleTitleLabels(ref optionLabels[Const.TITLE_LISTBOX_MEMBERS_SENDLIST]);
            optionLabels[Const.TITLE_LISTBOX_SENDLISTS].Text = "Доступные списки рассылки";
            optionLabels[Const.TITLE_LISTBOX_MEMBERS_SENDLIST].Text = "Список рассылки";

            this.workSpaceTableLayoutPanel.InitializeCellsCount(3, 4);
            this.workSpaceTableLayoutPanel.ColumnStyles.Insert(0, new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, columnWidth));
            this.workSpaceTableLayoutPanel.ColumnStyles.Insert(1, new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, columnWidth));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(0, new RowStyle(SizeType.Absolute, rowHeight));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(1, new RowStyle(SizeType.Percent, 90F));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(2, new RowStyle(SizeType.Absolute, rowHeight * 2));
            this.workSpaceTableLayoutPanel.RowStyles.Insert(3, new RowStyle(SizeType.Absolute, rowHeight * 2));

            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.TITLE_LISTBOX_MEMBERS_SENDLIST], 0, 0);
            this.workSpaceTableLayoutPanel.Controls.Add(optionLabels[Const.TITLE_LISTBOX_SENDLISTS], 0, 0);

            memberList = new ListBox[2];
            initOptions(ref memberList);
            memberList[Const.LISTS].Click += new EventHandler(SendList_Click);
            memberList[Const.MEMBERS_LIST].Click += new EventHandler(MemberSendList_Click);

            this.workSpaceTableLayoutPanel.Controls.Add(memberList[Const.LISTS], 0, 1);
            this.workSpaceTableLayoutPanel.Controls.Add(memberList[Const.MEMBERS_LIST], 1, 1);

            AppButton sendListButton = new AppButton();
            sendListButton.Text = "Сделать рассылку по списку";
            sendListButton.Click += new EventHandler(sendListButton_Click);
            this.workSpaceTableLayoutPanel.Controls.Add(sendListButton, 0, 2);

            AppButton sendMemberListButton = new AppButton();
            sendMemberListButton.Text = "Отправить контакту сообщение";
            sendMemberListButton.Click += new EventHandler(sendMemberListButton_Click);
            this.workSpaceTableLayoutPanel.SetRowSpan(sendMemberListButton, 2);
            this.workSpaceTableLayoutPanel.Controls.Add(sendMemberListButton, 1, 2);

            AppButton createNewSendListButton = new AppButton();
            createNewSendListButton.Text = "Создать новый список рассылки";
            createNewSendListButton.Click += new EventHandler(createNewSendListButton_Click);
            this.workSpaceTableLayoutPanel.Controls.Add(createNewSendListButton, 0, 3);

            PutInSendListBox();
            addToSendListButton = new Button();
            addToSendListButton.Location = bottomButton.Location;
            addToSendListButton.Size = bottomButton.Size;
            addToSendListButton.Text = "Добавить новый элемент в список";
            addToSendListButton.Click += new EventHandler(addToSendListButton_Click);
            this.bottomTableLayoutPanel.Controls.Remove(bottomButton);
            bottomButton.Visible = false;
            this.bottomTableLayoutPanel.Controls.Add(addToSendListButton);
        }

        private void createNewSendListButton_Click(object sender, EventArgs e) {
            CreateNewSendListForm createNewSendListForm = new CreateNewSendListForm();
            createNewSendListForm.Show();
        }

        private void sendMemberListButton_Click(object sender, EventArgs e) {
            string value = memberList[Const.MEMBERS_LIST].SelectedItem.ToString();
            value = value.Substring(value.LastIndexOf(' '));
            workSpaceTableLayoutPanel.Controls.Clear();
            createNewDelivery(Const.ONCE_MAIL);
            mailAdressDisTextBox.Text = value;
        }

        private void sendListButton_Click(object sender, EventArgs e) {
            int index = memberList[Const.LISTS].SelectedIndex;
            workSpaceTableLayoutPanel.Controls.Clear();
            createNewDelivery(Const.LIST_DELIVERY);
            chooseComboBox.SelectedIndex = index;
        }

        private void SendList_Click(object sender, EventArgs e) {
            PutInMemberListListBox(memberList[Const.LISTS].SelectedItem.ToString());
        }

        private void MemberSendList_Click(object sender, EventArgs e) {

        }

        private void addToSendListButton_Click(object sender, EventArgs e) {
            addNewItem = new AddToSendListNewItem();
            addNewItem.Show();
        }

        private void PutInSendListBox() {
            memberList[Const.LISTS].Items.Clear();
            memberList[Const.LISTS].Items.AddRange(Program.Data.PutInSendLists());
        }

        private void PutInMemberListListBox(string title) {
            memberList[Const.MEMBERS_LIST].Items.Clear();
            memberList[Const.MEMBERS_LIST].Items.AddRange(Program.Data.PutInMembersLists(title));
        }

        #endregion

        #endregion

        #region OnlineConference

        private void button1_Click_1(object sender, EventArgs e) {
            this.workSpaceTableLayoutPanel.Controls.Clear();
            initializeOnlineConferenceInterface();
        }

        private void initializeOnlineConferenceInterface() {
            ( new Form1() ).Show();
        }

        #endregion

        #endregion
    }
}