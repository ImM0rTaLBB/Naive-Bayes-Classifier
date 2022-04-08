using System;
using System.Data;

namespace ProbabilityFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sex");
            table.Columns.Add("Height", typeof(double));
            table.Columns.Add("Weight", typeof(double));
            table.Columns.Add("FootSize", typeof(double));

            //training data.
            table.Rows.Add("Male", 6, 180, 12);
            table.Rows.Add("Male", 5.92, 190, 11);
            table.Rows.Add("Male", 5.58, 170, 12);
            table.Rows.Add("Male", 5.92, 165, 10);
            table.Rows.Add("Male", 5.72, 155, 10);

            table.Rows.Add("Female", 5, 100, 6);
            table.Rows.Add("Female", 5.5, 150, 8);
            table.Rows.Add("Female", 5.42, 130, 7);
            table.Rows.Add("Female", 5.75, 150, 9);
            table.Rows.Add("Female", 5.85, 160, 7);

            table.Rows.Add("Transgender", 4, 200, 5);
            table.Rows.Add("Transgender", 4.10, 150, 8);
            table.Rows.Add("Transgender", 5.42, 190, 7);
            table.Rows.Add("Transgender", 5.50, 150, 9);


            Classifier classifier = new Classifier();
            classifier.TrainClassifier(table);

            Console.WriteLine(classifier.Classify(new double[] { 6, 180, 11 }));
            Console.Read();
        }
    }
}