using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> notes = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Console.WriteLine("Notes: " + string.Join(" ", DouubeToNote(notes)));
            List<double> noteNaturals = new List<double>();
            List<double> noteSharps = new List<double>();
            double sumNaturals = 0.0;
            double sumSharps = 0.0;
            for (int i = 0; i < notes.Count; i++)
            { 
                
                switch (notes[i])
                {
                    case 261.63:
                    case 293.66:
                    case 329.63:
                    case 349.23:
                    case 392.00:
                    case 440.00:
                    case 493.88:
                        noteNaturals.Add(notes[i]);
                        sumNaturals += notes[i];
                        break;
                    case 277.18:
                    case 311.13:
                    case 369.99:
                    case 415.30:
                    case 466.16:
                        noteSharps.Add(notes[i]);
                        sumSharps += notes[i];
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Naturals: " + string.Join(", ", DouubeToNote(noteNaturals)));
            Console.WriteLine("Sharps: " + string.Join(", ", DouubeToNote(noteSharps)));
            Console.WriteLine("Naturals sum: " + sumNaturals);
            Console.WriteLine("Sharps sum: " + sumSharps);
        }

        static List<string> DouubeToNote(List<double> notes)
        {
            List<string> newNotes = new List<string>();
            for (int i = 0; i < notes.Count; i++)
            {
                switch (notes[i])
                {
                    case 261.63: newNotes.Add("C");break;
                    case 277.18: newNotes.Add("C#"); break;
                    case 293.66: newNotes.Add("D"); break;
                    case 311.13: newNotes.Add("D#"); break;
                    case 329.63: newNotes.Add("E"); break;
                    case 349.23: newNotes.Add("F"); break;
                    case 369.99: newNotes.Add("F#"); break;
                    case 392.00: newNotes.Add("G"); break;
                    case 415.30: newNotes.Add("G#"); break;
                    case 440.00: newNotes.Add("A"); break;
                    case 466.16: newNotes.Add("A#"); break;
                    case 493.88: newNotes.Add("B"); break;
                    default: break;
                }
            }
            return newNotes;
        }
    }
}
