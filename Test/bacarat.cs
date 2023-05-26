using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class bacarat
    {

        public void CreateCard(Dictionary<string, int> mapCardScore, List<string> CardArray)
        {

            List<string> soBoBai = new List<string> { "Bộ 1", "Bộ 2" };
            List<string> danhSachChat = new List<string> { "Cơ", "Rô", "Tép", "Bích" };
            List<string> danhSachGiaTri = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "O", "J", "Q", "K" };

            foreach (string boBai in soBoBai)
            {
                foreach (string chat in danhSachChat)
                {
                    foreach (string giaTri in danhSachGiaTri)
                    {
                        string cardName = giaTri + " " + chat + " " + boBai;
                        CardArray.Add(cardName);
                    }
                }
            }
            RandomArray(CardArray);
            ConvertDictionary(mapCardScore, CardArray);
        }
        private void ConvertDictionary(Dictionary<string, int> dic, List<string> CardArray)
        {
            string[] danhSachGiaTri = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "O", "J", "Q", "K" };
            int[] giaTriTuongUng = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 0, 0, 0 };

            for (int i = 0; i < CardArray.Count; i++)
            {
                string card = CardArray[i]; // Át Cơ
                string giaTri = card.Substring(0, 1); // Lấy phần giá trị bỏ qua chất

                int index = Array.IndexOf(danhSachGiaTri, giaTri); // Tìm chỉ số của giá trị trong danh sách giá trị

                if (index != -1)
                {
                    int value = giaTriTuongUng[index];
                    dic[card] = value; // Thêm giá trị vào Dictionary
                }
                else
                {
                    Debug.Write(index + ": " + card);
                }
            }
        }
        private void RandomArray(List<string> CardArray)
        {
            Random random = new Random();

            for (int i = 0; i < CardArray.Count; i++)
            {
                int rdIndex = random.Next(i, CardArray.Count);

                string temp = CardArray[i];
                CardArray[i] = CardArray[rdIndex];
                CardArray[rdIndex] = temp;
            }
        }
        private List<string> DealCards(List<string> CardArray, ref int cardIndex, int count)
        {
            List<string> cards = new List<string>(count);
            for (int i = 0; i < count; i++)
            {
                cards[i] = CardArray[cardIndex];
                cardIndex++;
            }
            return cards;
        }
        private string DealCard(List<string> CardArray, ref int cardIndex)
        {
            string card = CardArray[cardIndex];
            cardIndex++;
            return card;
        }

        private int CalculateScore(List<string> hand, Dictionary<string, int> mapCardScore)
        {
            int score = 0;
            foreach (string card in hand)
            {
                score += mapCardScore[card];
            }
            return score % 10;
        }

        private void CompareScores(int playerScore, int bankerScore, ref int player, ref int banker, ref int equal)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Score = $"P:{playerScore}--B:{bankerScore}";
            if (playerScore > bankerScore)
            {
                Console.WriteLine("Player thắng " + Score );
                player += 1;
            }
            else if (playerScore < bankerScore)
            {
                Console.WriteLine("Banker thắng " + Score );
                banker += 1;
            }
            else
            {
                Console.WriteLine("Hòa" + Score);
                equal += 1;
            }
        }
        public void StartMatch(Dictionary<string, int> mapCardScore, List<string> CardArray, List<string> playerHand, List<string> bankerHand,
            ref int cardIndex, ref int player, ref int banker, ref int equal)
        {
            //playerHand.AddRange(DealCards(CardArray, ref cardIndex, 2));
            //bankerHand.AddRange(DealCards(CardArray, ref cardIndex, 2));

            // Lấy các lá bài cho Player và Banker
            playerHand.Add(DealCard(CardArray, ref cardIndex));
            bankerHand.Add(DealCard(CardArray, ref cardIndex));
            playerHand.Add(DealCard(CardArray, ref cardIndex));
            bankerHand.Add(DealCard(CardArray, ref cardIndex));

            int playerScore = CalculateScore(playerHand, mapCardScore);
            int bankerScore = CalculateScore(bankerHand, mapCardScore);

            if (playerScore < 6 && bankerScore < 6)
            {
                // Player lấy thêm 1 lá bài
                playerHand.Add(DealCard(CardArray, ref cardIndex));
                playerScore = CalculateScore(playerHand, mapCardScore);

                if (playerScore < bankerScore)
                {
                    banker++;
                    Console.WriteLine("Banker win");
                }
                else
                {
                    // Banker lấy thêm 1 lá bài
                    bankerHand.Add(DealCard(CardArray, ref cardIndex));
                    bankerScore = CalculateScore(bankerHand, mapCardScore);
                    CompareScores(playerScore, bankerScore, ref player, ref banker, ref equal);
                }
            }
            else if (playerScore < 6 && (bankerScore == 6 || bankerScore == 7))
            {
                // Player lấy thêm 1 lá bài
                playerHand.Add(DealCard(CardArray, ref cardIndex));
                playerScore = CalculateScore(playerHand, mapCardScore);
                CompareScores(playerScore, bankerScore, ref player, ref banker, ref equal);
            }
            else if (bankerScore < 6 && (playerScore == 6 || playerScore == 7))
            {
                // Banker lấy thêm 1 lá bài
                bankerHand.Add(DealCard(CardArray, ref cardIndex));
                bankerScore = CalculateScore(bankerHand, mapCardScore);
                CompareScores(playerScore, bankerScore, ref player, ref banker, ref equal);
            }
            else
            {
                CompareScores(playerScore, bankerScore, ref player, ref banker, ref equal);
            }


            ShowCard(playerHand, bankerHand);
        }

        private void ShowCard(List<string> playerHand, List<string> bankerHand)
        {
            string playerCard = $"Player: {string.Join("---", playerHand)}";
            string bankerCard = $"Banker: {string.Join("---", bankerHand)}";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(playerCard);
            Console.WriteLine(bankerCard);
        }


        public int RemoveCardArray(Dictionary<string, int> mapCardScore, List<string> cardArray, List<string> cards)
        {
            int indexRemove = 0;
            foreach (var card in cards)
            {
                if (mapCardScore.Remove(card) && cardArray.Remove(card))
                    indexRemove++;
            }

            return indexRemove;
        }

        private void CreateDic(Dictionary<int, string> dicValue, Dictionary<char, string> dicColor, Dictionary<int, string> dicAmount)
        {

            List<string> soBoBai = new List<string> { "Bộ 1", "Bộ 2", "Bộ 3", "Bộ 4" };
            List<string> danhSachChat = new List<string> { "Cơ", "Rô", "Tép", "Bích" };
            List<string> danhSachGiaTri = new List<string> { "Át", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for (int i = 0; i < soBoBai.Count; i++)
            {
                dicAmount.Add(i + 1, soBoBai[i]);
            }
            for (int i = 0; i < danhSachChat.Count; i++)
            {
                string nameColor = danhSachChat[i];
                char name = nameColor[0];
                dicColor.Add(name, nameColor);
            }
            for (int i = 0; i < danhSachGiaTri.Count; i++)
            {
                dicValue.Add(i + 1, danhSachGiaTri[i]);
            }
        }

        public string CreateString(int num, char c, int index)
        {
            return "abc";
        }
    }
}
