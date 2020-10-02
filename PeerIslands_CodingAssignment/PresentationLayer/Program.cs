using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace PeerIslands_CodingAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Db db = new Db();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(ConsoleConstants.ChoiceOperation);
                //Take input from user -Which CRUD operation to perform
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Choice.displayData(db);
                        break;
                    case 2:
                        db = Choice.insertData(db);
                        break;
                    case 3:
                        db = Choice.updateData(db);
                        break;
                    case 4:
                        db = Choice.deleteData(db);
                        break;
                    case 5:
                        db =Choice.displayLogs(db);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
