using System;
using System.Collections.Generic;
using System.Text;
using Menus;
using Tasks.Task4;

namespace Tasks
{
    class TasksMenu : Menu
    {

        //private Run RunProgram = new Run();
        public TasksMenu()
        {
            ButtonList = new List<Button> {
                new Button()
                {
                    Name = "Task1",
                    Description = "...",
                    Enabled = false,
                    Active = true

                },
                new Button()
                {
                    Name = "Task2",
                    Description = "...",
                    Enabled = false,
                    Active = true

                },
                new Button()
                {
                    Name = "Task3",
                    Description = "...",
                    Enabled = false,
                    Active = true

                },
                new Button(RunSumLeafs)
                {
                    Name = "Task4",
                    Description = "Suma Liści",
                    Enabled = true,
                    Active = true

                },
            };
            CurentActiveButton = 3;
        }

        public void RunSumLeafs()
        {
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                int?[] root = new int?[] { 1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8 };
                int?[] root2 = new int?[]  {6,7,8,2,7,1,3,9,null,1,4,null,null,null,5};
                Tree tree = new Tree(root);
                Console.WriteLine(tree.summary);
                tree = new Tree(root2);
                Console.WriteLine(tree.summary); ;
            }
            while ((consoleKeyInfo = Console.ReadKey()).Key != ConsoleKey.Escape);
        }
        
    }
}