var flag = false;
var bookNames = new List<string>();
var bookIsbnNos = new List<string>();
var bookAutherNames = new List<string>();
var borrowedBooks = new List<string>();
string bookIsbnNo;
do
{
    Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
    Console.WriteLine("PRESS 1 FOR MEMBER PORTAL\n" +
                      "PRESS 2 FOR ADMIN PORTAL");
    var mainMenuInput = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (mainMenuInput)
    {
        case 1:
            {

                Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                Console.WriteLine("**************************MEMBER PORTAL**********************");
                Console.WriteLine("PRESS 1 FOR BORROW BOOK\n" +
                                  "PRESS 2 FOR RETURN BOOK");
                var memberMenuInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (memberMenuInput)
                {
                    case 1:
                        {
                            Console.WriteLine("******************BORROW BOOK******************");
                            Console.Write("Enter Book ISBN No. to Borrow: ");
                             bookIsbnNo = Console.ReadLine();
                            var index = bookIsbnNos.IndexOf(bookIsbnNo);
                            if (index != -1 && !borrowedBooks.Contains(bookIsbnNo))
                            {
                                borrowedBooks.Add(bookIsbnNo);
                                Console.WriteLine("Book Borrowed Successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Book is not available or already borrowed.");
                                Console.Write("Enter Book ISBN No. to Return: ");
                                 bookIsbnNo = Console.ReadLine();
                                if (borrowedBooks.Contains(bookIsbnNo))
                                {
                                    borrowedBooks.Remove(bookIsbnNo);
                                    Console.WriteLine("Book Returned Successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Book was not borrowed.");
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("******************BORROW RETURN******************");
                            Console.Write("Enter Book ISBN No. to Return: ");
                            bookIsbnNo = Console.ReadLine();
                            if (borrowedBooks.Contains(bookIsbnNo))
                            {
                                borrowedBooks.Remove(bookIsbnNo);
                                Console.WriteLine("Book Returned Successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Book was not borrowed.");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("************************************");
                            break;
                        }
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                Console.WriteLine("**************************ADMIN PORTAL**********************");
                Console.WriteLine("PRESS 1 FOR MEMBER MANAGEMENT \n" +
                                  "PRESS 2 FOR BOOK   MANAGEMENT");
                var adminMenuInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (adminMenuInput)
                {
                    case 1:
                        {

                            Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                            Console.WriteLine("**************************ADMIN PORTAL**********************");
                            Console.WriteLine("**********************MEMBER MANAGEMENT******************");
                            Console.WriteLine("PRESS 1 TO ADD MEMBER \n" +
                                              "PRESS 2 TO DELETE MEMBER\n" +
                                              "PRESS 3 TO SEE MEMBER DETAILS\n" +
                                              "PRESS 4 TO EDIT MEMBER ");

                            var memberMangeMenuInput = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (memberMangeMenuInput)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("******************ADD MEMBER******************");
                                        Console.Write("Please Enter Member Name : ");
                                        var memberName = Console.ReadLine();
                                        Console.Write("Please Enter Member ID : ");
                                        var memberID = Console.ReadLine();
                                        Console.Write("Please Enter Member Address: ");
                                        var memberAddress = Console.ReadLine();
                                        var fileName = $@"D:\Projects\lms\member\{memberID}.txt";
                                        if (!File.Exists(fileName))
                                        {
                                            File.AppendAllText(fileName, "Member Name      : " + memberName);
                                            File.AppendAllText(fileName, "\nMember ID       : " + memberID);
                                            File.AppendAllText(fileName, "\nMember Address  : " + memberAddress);
                                            Console.WriteLine("Data Entered Successfully . . .");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Member with same ID Already Exists");
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("******************DELETE MEMBER******************");
                                        Console.Write("Please Enter Member ID : ");
                                        var memberID = Console.ReadLine();
                                        var fileName = $@"D:\Projects\lms\member\{memberID}.txt";
                                        if (File.Exists(fileName))
                                        {
                                            File.Delete(fileName);
                                            Console.WriteLine("Data Deleted Successfully . . .");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Member Not Exists . . .");
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("******************MEMBER DETAILS******************");
                                        Console.Write("Please Enter Member ID : ");
                                        var memberID = Console.ReadLine();
                                        var fileName = $@"D:\Projects\lms\member\{memberID}.txt";
                                        if (File.Exists(fileName))
                                        {
                                            var FileData = File.ReadAllText(fileName);
                                            Console.WriteLine(FileData);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Member Not Exists");
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("******************EDIT MEMBER******************");
                                        Console.Write("Please Enter Member ID : ");
                                        var memberID = Console.ReadLine();
                                        var fileName = $@"D:\Projects\lms\member\{memberID}.txt";
                                        if (File.Exists(fileName))
                                        {
                                            Console.Write("Please Enter Member Name : ");
                                            var memberName = Console.ReadLine();
                                            Console.Write("Please Enter Member Address: ");
                                            var memberAddress = Console.ReadLine();
                                            File.WriteAllText(fileName, "Member Name      : " + memberName);
                                            File.AppendAllText(fileName, "\nMember ID       : " + memberID);
                                            File.AppendAllText(fileName, "\nMember Address  : " + memberAddress);
                                            Console.WriteLine("Data Edited Successfully . . .");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Member Not Exists . . .");
                                        }
                                        break;
                                    }

                                default:
                                    {
                                        Console.WriteLine("************************************");
                                        break;
                                    }
                            }

                            break;
                        }
                    case 2:
                        {
                          
                            Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                            Console.WriteLine("**************************ADMIN PORTAL**********************");
                            Console.WriteLine("*************************BOOK MANAGEMENT************************");
                            Console.WriteLine("PRESS 1 TO ADD BOOK \n" +
                                              "PRESS 2 TO DELETE BOOK\n" +
                                              "PRESS 3 TO SEE BOOK DETAILS\n" +
                                              "PRESS 4 TO EDIT BOOk Details ");

                            var bookMangeMenuInput = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (bookMangeMenuInput)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("******************ADD BOOK******************");
                                        Console.Write("Enter Book Name : ");
                                        var bookName = Console.ReadLine();
                                        Console.Write("Enter Book ISBN No.  : ");
                                        bookIsbnNo = Console.ReadLine();
                                        Console.Write("Enter Author Name : ");
                                        var bookAutherName = Console.ReadLine();

                                        bookNames.Add(bookName);
                                        bookIsbnNos.Add(bookIsbnNo);
                                        bookAutherNames.Add(bookAutherName);

                                        Console.WriteLine("Book Added Successfuly");


                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("******************BOOK Details******************");
                                        Console.WriteLine("Enter Book ISBN No.  : ");
                                        bookIsbnNo = Console.ReadLine();
                                        var index = bookIsbnNos.IndexOf(bookIsbnNo);
                                        bookNames.RemoveAt(index);
                                        bookIsbnNos.RemoveAt(index);
                                        bookAutherNames.RemoveAt(index);
                                        Console.WriteLine("data deleted");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("******************BOOK Details******************");
                                        Console.WriteLine("Enter Book ISBN No.  : ");
                                        bookIsbnNo = Console.ReadLine();
                                        var index = bookIsbnNos.IndexOf(bookIsbnNo);

                                        Console.WriteLine("Book Name : " + bookNames[index] + "\n Book ISBN NO. :" + bookIsbnNos[index] + "\nBook Auther : " + bookAutherNames[index]);

                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("******************Edit BOOK Details******************");
                                        Console.WriteLine("Enter Book ISBN No.  : ");
                                        bookIsbnNo = Console.ReadLine();
                                        var index = bookIsbnNos.IndexOf(bookIsbnNo);
                                        Console.WriteLine("Ente Book Name :");
                                        var bookName = Console.ReadLine();
                                        Console.Write("Enter Book Auther Name  No.  : ");
                                        var bookAutherName = Console.ReadLine();
                                        bookNames.RemoveAt(index);
                                        bookNames.Insert(index,bookName);

                                        bookAutherNames.RemoveAt(index);
                                        bookAutherNames.Insert(index,bookAutherName);

                                        Console.WriteLine("Book Added Successfuly");

                                        break;
                                    } 
                                default:
                                    {

                                        break;
                                    }
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("************************************");
                            break;
                        }
                }
                break;
            }
        case 0:
            {
                Console.WriteLine("************************************");
                break;
            }
        default:
            {
                Console.WriteLine("************************************");
                break;
            }
    }

    Console.WriteLine("press 0 to exit ");
 
    var flagInput = Console.ReadLine();
    if (flagInput =="0")
    {
        flag = false;
    }
    else
    {
        flag = true;
    }
} while (flag);


