﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
         
            

            Deck deck = new Deck();
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberList.Sum(x=> x+5);
            Console.WriteLine(sum);
          
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            { 
                Console.WriteLine(card.Face + " of " + card.Suit); 
            
            }
            Console.WriteLine(deck.Cards.Count);
            
            Console.ReadLine(); 
            
            
        }
       
       
    }
}
