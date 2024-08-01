using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.PlugBoard
{
      public class PlugBoard
      {   //field
          private Dictionary<char, char> wiring;


          //constructor
          public PlugBoard(string wires="")
          {
              if (wires.Length > 20)
              {
                  throw new ArgumentException("Too many wire inputs");
              }
              wiring = new Dictionary<char, char>();
              //iterate through input in pairs
              for (int i = 0; i < wires.Length; i+=2)
              {

                  char firstLetter = wires[i];
                  char secondLetter = wires[i + 1];

                  if (wiring.ContainsKey(firstLetter) || wiring.ContainsKey(secondLetter))
                  {
                      throw new ArgumentException("Wire Pairing already exists");
                  }
                  wiring[firstLetter] = secondLetter;
                  wiring[secondLetter] = firstLetter;
              }
          }

          // method
          public char Process(char input)
          {
              if (wiring.ContainsKey(input))
              {
                  return wiring[input];
              }
              return input;
          }

      }
  }









//    public class Wire
//    {
//        public char End1 { get; }
//        public char End2 { get; }

//        public Wire(char end1, char end2)
//        {
//            End1 = end1;
//            End2 = end2;
//        }

//        public bool Connects(char letter)
//        {
//            return End1 == letter || End2 == letter;
//        }

//        public char Translate(char letter)
//        {
//            if (letter == End1) return End2;
//            if (letter == End2) return End1;
//            return letter;
//        }
//    }


//    public class CharacterTranslator
//    {
//        public  List<Wire> wires;

//        public CharacterTranslator(IEnumerable<Wire> wires)
//        {
//            this.wires = new List<Wire>(wires);
//        }

//        public char Translate(char letter)
//        {
//            foreach (var wire in wires)
//            {
//                if (wire.Connects(letter))
//                {
//                    return wire.Translate(letter);
//                }
//            }
//            return letter;
//        }
//    }

//    public class Plugboard
//    {
//        public  CharacterTranslator translator;

//        public Plugboard(string wires = "")
//        {

//            if (wires.Length > 20)
//            {
//                throw new ArgumentException("Cannot have more than 10 wire pairs");
//            }

//            var wireList = new List<Wire>();
//            translator = new CharacterTranslator(wireList);
//            for (int i = 0; i < wires.Length; i += 2)
//            {
//                char end1 = wires[i];
//                char end2 = wires[i + 1];

 
//                bool duplicateFound = false;
//                foreach (Wire existingWire in wireList)
//                {
//                    if (existingWire.Connects(end1) || existingWire.Connects(end2))
//                    {
//                        duplicateFound = true;
//                        break;
//                    }
//                }

//                if (duplicateFound)
//                {
//                    throw new ArgumentException("Duplicate wire connections detected");
//                }

//                wireList.Add(new Wire(end1, end2));
//            }


//        }

//        public char Process(char c)
//        {
//            return translator.Translate(c);
//        }
//    }
//}