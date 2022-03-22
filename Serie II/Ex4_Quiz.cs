using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public struct Qcm
    {
        public string Question;
        public string[] Answers;
        public int Solution;
        public int Weight;

        public Qcm(string q, string[] a, int s, int w)
        {
            Question = q;
            Answers = a;
            Solution = s;
            Weight = w;
        }
    }

    public static class Quiz
    {
        public static void AskQuestions(Qcm[] qcms)
        {
            int points = 0;
            int max = 0;

            for (int i = 0; i < qcms.Length; i++)
            {
                points += AskQuestion(qcms[i]);
                max += qcms[i].Weight;
            }

            Console.WriteLine($"Résultats du questionnaire : {points}/{max}");
        }

        public static int AskQuestion(Qcm qcm)
        {
            int ans;

            if (!QcmValidity(qcm))
                throw new ArgumentException();

            Console.WriteLine(qcm.Question);

            for (int i = 0; i < qcm.Answers.Length; i++)
                Console.Write($"{i + 1}. {qcm.Answers[i]} ");

            Console.Write($"\nRéponse : ");

            while(!int.TryParse(Console.ReadLine(), out ans) || ans < 1 || ans > qcm.Answers.Length)
            {
                Console.WriteLine("Réponse invalide!");
                Console.Write($"Réponse : ");
            }

            return ans == qcm.Solution ? qcm.Weight : 0;
        }

        public static bool QcmValidity(Qcm qcm)
        {
            return qcm.Solution <= qcm.Answers.Length && qcm.Solution > 0 && qcm.Weight > 0;
        }
    }
}
