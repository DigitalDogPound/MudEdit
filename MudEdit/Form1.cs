namespace MudEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            {
                settings.ShowDialog();
            }

        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actions actions = new actions();
            {
                actions.ShowDialog();
            }
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            {
                classes.ShowDialog();
            }
        }

        private void gangsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gangs gangs = new Gangs();
            {
                gangs.ShowDialog();
            }
        }

        private void itemsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            {
                items.ShowDialog();
            }
        }

        private void monstersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Monsters monsters = new Monsters();
            {
                monsters.ShowDialog();
            }
        }

        private void racesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Races races = new Races();
            {
                races.ShowDialog();
            }
        }

        private void roomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            {
                rooms.ShowDialog();
            }
        }

        private void shopsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Shops shops = new Shops();
            {
                shops.ShowDialog();
            }
        }

        private void spellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spells spells = new Spells();
            {
                spells.ShowDialog();
            }
        }

        private void textblocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Textblocks textblocks = new Textblocks();
            {
                textblocks.ShowDialog();
            }
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            {
                users.ShowDialog();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataExport export = new DataExport();
            {
                export.ShowDialog();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataImport import = new DataImport();
            {
                import.ShowDialog();
            }
        }

        private void divideAllExpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonsterDivideXP divide = new MonsterDivideXP();
            {
                divide.ShowDialog();
            }
        }

        private void multiplyAllExpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonsterMultiXP multiXP  = new MonsterMultiXP();
            {
                multiXP.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            {
                about.ShowDialog();
            }
        }
    }
}