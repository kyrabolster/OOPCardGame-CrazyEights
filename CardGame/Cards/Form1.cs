using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer;

/*
 * Kyra Bolster
 * OOP - Card Game
 * April 12, 2020
 */

namespace Cards
{
    public partial class Form1 : Form
    {
        private Deck aDeck;
        private Hand hand1;
        private Hand hand2;
        private Hand discardPile;
        private Turn turn;

        bool p1HasPicked = false;
        bool p2HasPicked = false;
        bool isCrazyEight = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetUp();
        }

        private void SetUp()
        {
            try
            {
                grpCrazyEight.Visible = false;
                grpCrazyEight.Enabled = false;
                lblSuit.Visible = false;
                PanelPick.Visible = true;

                p1HasPicked = false;
                p2HasPicked = false;
                isCrazyEight = false;

                turn = Turn.Player1;
                lblTurn.Text = "Player1's Turn";
                lblWinner.Text = "";

                string imgPath = @"images\cardback.gif";

                PictureBox pic = new PictureBox()
                {
                    Image = Image.FromFile(imgPath),
                    Width = 70,
                    Height = 100,
                    Left = 75
                };

                pic.Click += PickPile_Click;
                PanelPick.Controls.Add(pic);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                aDeck = new Deck();
                aDeck.Shuffle();
                DealHands();

                discardPile.AddCard(aDeck.DrawOneCard());
                ShowHand(PanelDiscard, discardPile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DealHands()
        {
            try
            {
                hand1 = aDeck.DealHand(8);
                ShowHand(Panel1, hand1);

                hand2 = aDeck.DealHand(8);
                ShowHand(Panel2, hand2);

                discardPile = new Hand();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


        private void ShowHand(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();
            Card aCard;
            PictureBox aPic;

            for (int i = 0; i < theHand.Count; i++)
            {
                aCard = theHand[i];
                string path = @"images\" + aCard.FaceValue.ToString() + aCard.Suit.ToString() + ".jpg";

                aPic = new PictureBox()
                {
                    Image = Image.FromFile(path),
                    Text = aCard.FaceValue.ToString(),
                    Width = 70,
                    Height = 100,
                    Left = 75 * i,
                    Tag = aCard
                };

                aPic.Click += Hand_Click;
                aPic.SizeMode = PictureBoxSizeMode.StretchImage;

                thePanel.Controls.Add(aPic);
            }
        }

        /// <summary>
        /// Changes turn
        /// </summary>
        private void ChangeTurn()
        {

            if (turn == Turn.Player1)
            {
                turn = Turn.Player2;
                p2HasPicked = false;
            }
            else
            {
                turn = Turn.Player1;
                p1HasPicked = false;
            }
            lblTurn.Text = $"{turn}'s Turn";
        }

        /// <summary>
        /// Displays Crazy Eight suit select panel
        /// </summary>
        private void CrazyEight()
        {
            grpCrazyEight.Visible = true;
            grpCrazyEight.Enabled = true;
            isCrazyEight = true;
        }

        /// <summary>
        /// Sets suit to selected suit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoHearts.Checked)
            {
                discardPile[0].Suit = Suit.Hearts;
            }
            else if (rdoDiamonds.Checked)
            {
                discardPile[0].Suit = Suit.Diamonds;
            }
            else if (rdoSpades.Checked)
            {
                discardPile[0].Suit = Suit.Spades;
            }
            else if (rdoClubs.Checked)
            {
                discardPile[0].Suit = Suit.Clubs;
            }
            else { return; }

            lblSuit.Visible = true;
            lblSuit.Text = $"The new suit is: {discardPile[0].Suit.ToString()}";

            grpCrazyEight.Visible = false;
            grpCrazyEight.Enabled = false;
            ((RadioButton)sender).Checked = false;
            isCrazyEight = false;

            ChangeTurn();
        }

        /// <summary>
        /// Opposite player picks up two cards when 2 is laid
        /// </summary>
        private void PickUpTwo()
        {
            MessageBox.Show("Click OK to Pick up two!", "Pick up two");

            try
            {
                if (turn == Turn.Player1)
                {
                    hand2.AddCard(aDeck.DrawOneCard());
                    hand2.AddCard(aDeck.DrawOneCard());
                    ShowHand(Panel2, hand2);
                }
                else
                {
                    hand1.AddCard(aDeck.DrawOneCard());
                    hand1.AddCard(aDeck.DrawOneCard());
                    ShowHand(Panel1, hand1);
                }
            }
            catch { EndGame(); }
        }

        /// <summary>
        /// Skip opposite player's turn when Jack laid
        /// </summary>
        private void SkipYourTurn()
        {
            ChangeTurn();
            MessageBox.Show($"Skip Your Turn! Skip {turn}'s turn.", "Skip your turn");
        }

        /// <summary>
        /// Pick up a card from deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PickPile_Click(object sender, EventArgs e)
        {
            if (isCrazyEight) { return;  }

            PictureBox picClicked = (PictureBox)sender;
            int pickPile = PanelPick.Controls.IndexOf(picClicked);

            string alreadyPicked = "You can only pick one card per round.";
            Panel turnPanel;
            Hand turnHand;

            if (turn == Turn.Player1)
            {
                turnHand = hand1;
                turnPanel = Panel1;
                if (p1HasPicked)
                {
                    MessageBox.Show(alreadyPicked, "Invalid Move");
                    return;
                }
                p1HasPicked = true;
            }
            else
            {
                turnHand = hand2;
                turnPanel = Panel2;
                if (p2HasPicked)
                {
                    MessageBox.Show(alreadyPicked, "Invalid Move");
                    return;
                }
                p2HasPicked = true;
            }

           
            try { turnHand.AddCard(aDeck.DrawOneCard()); }
            catch { EndGame(); }
            ShowHand(turnPanel, turnHand);
        }

        /// <summary>
        /// Select card from hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hand_Click(object sender, EventArgs e)
        {
            if (isCrazyEight) { return; }

            PictureBox picClicked;
            try { picClicked = (PictureBox)sender; }
            catch
            {
                MessageBox.Show("Please click on a card.", "Invalid Click");
                return;
            }

            int p1Hand = Panel1.Controls.IndexOf(picClicked);
            int p2Hand = Panel2.Controls.IndexOf(picClicked);
            Panel turnPanel = (Panel)((PictureBox)sender).Parent;

            Card selectedCard = (Card)picClicked.Tag;
            Hand turnHand;

            lblSuit.Visible = false;

            // whose turn
            if (p1Hand != -1 && turn == Turn.Player1) { turnHand = hand1; }

            else if (p2Hand != -1 && turn == Turn.Player2) { turnHand = hand2; }

            else
            {
                MessageBox.Show($"It is {turn}'s turn.", "Invalid Move");
                return;
            }

            // reference hand class methods then calls form methods
            if (turnHand.isEight(selectedCard)) { CrazyEight(); }

            else if (discardPile.isValidDiscard(selectedCard))
            {
                if (turnHand.isTwo(selectedCard)) { PickUpTwo(); }
                else if (turnHand.isJack(selectedCard)) { SkipYourTurn(); }

                ChangeTurn();
            }
            else
            {
                MessageBox.Show("Nice Try! " +
                            "\r\nYou must match the suit or face value of the card in the discard pile.\r\n" +
                            "If you cannot go, pick a card from the deck pile.", "Invalid Move");
                return;
            }

            turnHand.RemoveCard(selectedCard);
            ShowHand(turnPanel, turnHand);

            discardPile.Clear();
            discardPile.AddCard(selectedCard);
            ShowHand(PanelDiscard, discardPile);

            // end game
            if (hand1.NoCardsLeft() || hand2.NoCardsLeft()) { EndGame(); }
        }

        /// <summary>
        /// End game and determine winner when player runs out of cards
        /// </summary>
        private void EndGame()
        {
            if (hand1.Count < hand2.Count)
            {
                lblWinner.Text = "Player 1 Wins!";
                grpCrazyEight.Visible = false;
                PanelPick.Visible = false;
            }
            else if (hand1.Count == hand2.Count)
            {
                lblWinner.Text = "Tie Game!";
                PanelPick.Visible = false;
            }
            else
            {
                lblWinner.Text = "Player 2 Wins!";
                grpCrazyEight.Visible = false;
                PanelPick.Visible = false;
            }
        }

        /// <summary>
        /// End turn if player picked up and still does not have a valid card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (isCrazyEight) { return; }

            if ((turn == Turn.Player1 && !p1HasPicked) || (turn == Turn.Player2 && !p2HasPicked))
            {
                    MessageBox.Show("You must pick up or discard to end your turn.", "Invalid Move");
                    return;
            }

            p1HasPicked = false;
            p2HasPicked = false;
            ChangeTurn();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetUp();
        }
    }
}
