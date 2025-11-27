using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_typing_trainer
{
    public partial class Form1 : Form
    {
        Dictionary<Keys, Button> keyMap = new Dictionary<Keys, Button>();
        Dictionary<string, string> storyMap = new Dictionary<string, string>();
        int currentPosition = 0;
        int Mistakes = 0;
        int totalTime = 60; 
        int timeLeft = 60;  
        bool isGameRunning = false;

        public Form1()
        {
            InitializeComponent();
           
            initializeKeyMap();
            initializeStoryMap();

        }
        public void initializeKeyMap()
        {
            keyMap.Add(Keys.A, btnA);
            keyMap.Add(Keys.B, btnB);
            keyMap.Add(Keys.C, btnC);
            keyMap.Add(Keys.D, btnD);
            keyMap.Add(Keys.E, btnE);
            keyMap.Add(Keys.F, btnF);
            keyMap.Add(Keys.G, btnG);
            keyMap.Add(Keys.H, btnH);
            keyMap.Add(Keys.I, btnI);
            keyMap.Add(Keys.J, btnJ);
            keyMap.Add(Keys.K, btnK);
            keyMap.Add(Keys.L, btnL);
            keyMap.Add(Keys.M, btnM);
            keyMap.Add(Keys.N, btnN);
            keyMap.Add(Keys.O, btnO);
            keyMap.Add(Keys.P, btnP);
            keyMap.Add(Keys.Q, btnQ);
            keyMap.Add(Keys.R, btnR);
            keyMap.Add(Keys.S, btnS);
            keyMap.Add(Keys.T, btnT);
            keyMap.Add(Keys.U, btnU);
            keyMap.Add(Keys.V, btnV);
            keyMap.Add(Keys.W, btnW);
            keyMap.Add(Keys.X, btnX);
            keyMap.Add(Keys.Y, btnY);
            keyMap.Add(Keys.Z, btnZ);
            keyMap.Add(Keys.Space, btnSpace);
            keyMap.Add(Keys.Back, btnBackSpace);
            keyMap.Add(Keys.ShiftKey, btnShift);
            keyMap.Add(Keys.Enter, btnEnter);
            keyMap.Add(Keys.OemPeriod, btnperiod);
            keyMap.Add(Keys.Oemcomma, btnComma);

        }
        public void initializeStoryMap()
        {
            storyMap.Add("Morning in the village", "the morning sky glows with soft colors as people begin their day and the quiet streets slowly fill with movement some walk to work while others ride bicycles along the narrow paths that pass between rows of small houses children laugh as they run through open fields chasing each other and picking flowers from the ground the fresh air brings a calm feeling and everyone seems to enjoy the gentle start of a new day");
            storyMap.Add("Valley Harvest Day", "in a wide open valley farmers work together planting seeds in the rich soil the sun shines warmly over the land and the sound of animals can be heard in the distance cows graze lazily while birds soar above looking for food the farmers move with steady rhythm trusting that their work will bring a good harvest later in the year the valley is peaceful and full of life and many visitors come to admire the natural beauty that stretches far in every direction");
            storyMap.Add("Coastline Afternoon", "near the coastline waves roll gently toward the shore and the smell of salt fills the air people gather to relax on the sand some reading quietly and others walking along the water leaving footprints that quickly fade away the wind carries the sound of laughter from a group of friends who play simple games by the rocks the ocean sparkles under the sunlight and the entire place feels calm and endless as if time moves a little slower by the sea");
            storyMap.Add("City Before Sunrise", "The city was awake long before sunrise, and by the time the first buses arrived, dozens of people were already waiting at the station. Some carried backpacks, others held cups of hot coffee, and a few stood quietly with their headphones on. As the traffic lights changed in slow rhythm, the streets hummed with the familiar sound of engines, footsteps, and distant conversations. Despite the rush, every corner of the city held its own small piece of calm, from a quiet bookstore opening its doors to a park bench touched by the first light of day.");
            storyMap.Add("Highway Notebook", "During the long road trip, Emma kept a small notebook beside her, writing down anything interesting she saw. At one point, she spotted an abandoned house on a hill, its windows broken and its roof partly collapsed. “There must be a story behind that place,” she whispered, imagining who might have lived there long ago. The highway stretched endlessly ahead, passing old farms, wide rivers, and dense forests. With every mile, the scenery changed, filling the journey with mystery, beauty, and quiet curiosity.");
            storyMap.Add("The Incoming Storm", "When the storm rolled in, the sky darkened so quickly that everyone on the beach stopped what they were doing. Winds swept across the sand, lifting grains into the air as the waves grew taller with each minute. Families packed their bags, lifeguards blew their whistles, and boats rushed back toward the harbor. Just as the first raindrops fell, a flash of lightning illuminated the coast, revealing heavy clouds pushing in like a massive wall. Seconds later, the downpour began, turning the warm afternoon into a dramatic stormy scene.");
            storyMap.Add("Echoes of the Observatory", "Long after the researchers had left, the observatory remained filled with the soft hum of cooling instruments, and faint reflections drifted across the polished floor. Dr. Hale reviewed his notes again, puzzled by a distant signal that appeared randomly yet repeated with an almost intentional rhythm. Although the data looked ordinary at first glance, something about the pattern felt strangely deliberate—too structured to dismiss, yet too inconsistent to classify. As he stared into the quiet dome above, he wondered whether the signal was merely noise or the first hint of a discovery no one had expected.");
            storyMap.Add("Archive of Unraveled Stories", "The old archive, hidden beneath the museum, housed thousands of documents organized in ways no modern system could easily explain. Some folders were meticulously labeled, while others were stuffed with mismatched pages that clearly belonged to different eras. When Mira opened one of the cabinets, a gust of stale air swept out, carrying the faint scent of ink and forgotten ideas. Several notes contained symbols she didn’t recognize, alongside carefully scribbled margins suggesting multiple authors had added thoughts over decades. Every new page raised more questions than answers, drawing her deeper into the maze of unresolved history.");
            storyMap.Add("The Clockmaker’s Dilemma", "Elias studied the delicate arrangement of gears spread across his workbench, each one crafted with such precision that a single scratch could ruin the entire mechanism. The experimental device he was building relied on perfect synchronization, yet the smallest fluctuation in temperature caused the components to shift unpredictably. He tightened a micro-spring, paused, then adjusted it again after noticing a subtle imbalance in its tension. Despite the frustration, he felt a quiet thrill: solving these intricate problems was the very reason he had devoted his life to the craft, even when success seemed impossibly out of reach.");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyMap.ContainsKey(e.KeyCode))
            {
                Button targetedButton = keyMap[e.KeyCode];
                targetedButton.BackColor = Color.Turquoise;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            if(isGameRunning)
            {
                string targetText = richTextBox1.Text;

                if (currentPosition < targetText.Length && e.KeyChar == targetText[currentPosition])
                {
                    richTextBox1.Select(currentPosition, 1);
                    richTextBox1.SelectionColor = Color.LightGreen; 
                    richTextBox1.SelectionBackColor = richTextBox1.BackColor; 

                    currentPosition++;

                    if (currentPosition < targetText.Length)
                    {
                        richTextBox1.Select(currentPosition, 1);
                        richTextBox1.SelectionBackColor = Color.Orange; 
                    }

                }
                else
                {
                    richTextBox1.Select(currentPosition, 1);
                    richTextBox1.SelectionColor = Color.Red;
                    Mistakes++;
                }

                e.Handled = true;
            }
           
    
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyMap.ContainsKey(e.KeyCode))
            {
                Button targetedButton = keyMap[e.KeyCode];
                targetedButton.BackColor = Color.FromArgb(62, 62, 66);
            }

        }
        private void btnEasy_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Morning in the village");
            comboBox1.Items.Add("Valley Harvest Day");
            comboBox1.Items.Add("Coastline Afternoon");
            comboBox1.SelectedItem = "Morning in the village";


        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("City Before Sunrise");
            comboBox1.Items.Add("Highway Notebook");
            comboBox1.Items.Add("The Incoming Storm");
            comboBox1.SelectedItem = "City Before Sunrise";

        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Echoes of the Observatory");
            comboBox1.Items.Add("Archive of Unraveled Stories");
            comboBox1.Items.Add("The Clockmaker’s Dilemma");
            comboBox1.SelectedItem = "Echoes of the Observatory";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetGame();
            resetVisuals();
            richTextBox1.Text = storyMap[comboBox1.Text];
        }
        private int calculateAccuracy()
        {
            return (int)(((double)(currentPosition - Mistakes) / currentPosition) * 100);
        }
        private int calculateWPM()
        {
            return (int)((currentPosition / 5) / (totalTime/60.0));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            resetVisuals();
            resetGame();
            isGameRunning = true;
            timer1.Start();
            richTextBox1.Focus();
        }
        private void resetVisuals()
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            richTextBox1.Select(0, 0);
        }
        private void resetGame()
        {
            totalTime = Convert.ToInt32(comboBox2.Text.Substring(0, 2));
            timeLeft = totalTime;
            isGameRunning = false;
            currentPosition = 0;
            Mistakes = 0;
        }
        private void endGame()
        {
            int accuracy = calculateAccuracy();
            int wpm = calculateWPM();
            MessageBox.Show($"total seconds = {totalTime}\n\nnumber of mistakes: {Mistakes} \n\nWPM: {wpm}\n\n accuracy: {accuracy}%");
           resetGame();
            resetVisuals();
        }
        private void isEndGame()
        {
            if (timeLeft == 0)
            {
                timer1.Stop();
                endGame();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lbtimer.Text = timeLeft.ToString();
           isEndGame();
        }
    }
}
