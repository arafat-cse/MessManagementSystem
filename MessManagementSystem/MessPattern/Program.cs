using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the repositories
            IRepository userRepository = new UserRepository();
            IRepository messRepository = new MessRepository();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMess Management System (MMS)");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. Update User");
                Console.WriteLine("4. Display User");
                Console.WriteLine("5. Add Mess");
                Console.WriteLine("6. Remove Mess");
                Console.WriteLine("7. Update Mess");
                Console.WriteLine("8. Display Mess");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Add User
                        Console.Write("Enter User Name: ");
                        string userName = Console.ReadLine();

                        Console.Write("Enter User Address: ");
                        string userAddress = Console.ReadLine();

                        Console.Write("Enter User Phone Number: ");
                        string userPhone = Console.ReadLine();

                        Console.Write("Enter User Email: ");
                        string userEmail = Console.ReadLine();

                        User newUser = new User
                        {
                            Name = userName,
                            Adress = userAddress,
                            PhoneNumber = userPhone,
                            Email = userEmail
                        };

                        userRepository.Create(newUser);
                        Console.WriteLine("User added successfully!");
                        break;

                    case "2": // Remove User
                        Console.Write("Enter User ID to remove: ");
                        int removeUserId = int.Parse(Console.ReadLine());
                        userRepository.Delete(removeUserId);
                        Console.WriteLine("User removed successfully!");
                        break;

                    case "3": // Update User
                        Console.Write("Enter User ID to update: ");
                        int updateUserId = int.Parse(Console.ReadLine());

                        Console.Write("Enter New User Name: ");
                        string newUserName = Console.ReadLine();

                        Console.Write("Enter New User Address: ");
                        string newUserAddress = Console.ReadLine();

                        Console.Write("Enter New User Phone Number: ");
                        string newUserPhone = Console.ReadLine();

                        Console.Write("Enter New User Email: ");
                        string newUserEmail = Console.ReadLine();

                        User updatedUser = new User
                        {
                            Id = updateUserId,
                            Name = newUserName,
                            Adress = newUserAddress,
                            PhoneNumber = newUserPhone,
                            Email = newUserEmail
                        };

                        userRepository.Update(updatedUser);
                        Console.WriteLine("User updated successfully!");
                        break;

                    case "4": // Display User
                        Console.Write("Enter User ID to display: ");
                        int displayUserId = int.Parse(Console.ReadLine());
                        var user = userRepository.Read(displayUserId) as User;

                        if (user != null)
                        {
                            Console.WriteLine($"User Details: ID: {user.Id}, Name: {user.Name}, Address: {user.Adress}, Phone: {user.PhoneNumber}, Email: {user.Email}");
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                        }
                        break;

                    case "5": // Add Mess
                        Console.Write("Enter Mess Name: ");
                        string messName = Console.ReadLine();

                        Console.Write("Enter Mess Address: ");
                        string messAddress = Console.ReadLine();

                        Console.Write("Enter Mess Phone Number: ");
                        string messPhone = Console.ReadLine();

                        Console.Write("Enter Mess Email: ");
                        string messEmail = Console.ReadLine();

                        Mess newMess = new Mess
                        {
                            Name = messName,
                            Adress = messAddress,
                            PhoneNumber = messPhone,
                            Email = messEmail
                        };

                        messRepository.Create(newMess);
                        Console.WriteLine("Mess added successfully!");
                        break;

                    case "6": // Remove Mess
                        Console.Write("Enter Mess ID to remove: ");
                        int removeMessId = int.Parse(Console.ReadLine());
                        messRepository.Delete(removeMessId);
                        Console.WriteLine("Mess removed successfully!");
                        break;

                    case "7": // Update Mess
                        Console.Write("Enter Mess ID to update: ");
                        int updateMessId = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Mess Name: ");
                        string newMessName = Console.ReadLine();

                        Console.Write("Enter New Mess Address: ");
                        string newMessAddress = Console.ReadLine();

                        Console.Write("Enter New Mess Phone Number: ");
                        string newMessPhone = Console.ReadLine();

                        Console.Write("Enter New Mess Email: ");
                        string newMessEmail = Console.ReadLine();

                        Mess updatedMess = new Mess
                        {
                            Id = updateMessId,
                            Name = newMessName,
                            Adress = newMessAddress,
                            PhoneNumber = newMessPhone,
                            Email = newMessEmail
                        };

                        messRepository.Update(updatedMess);
                        Console.WriteLine("Mess updated successfully!");
                        break;

                    case "8": // Display Mess
                        Console.Write("Enter Mess ID to display: ");
                        int displayMessId = int.Parse(Console.ReadLine());
                        var mess = messRepository.Read(displayMessId) as Mess;

                        if (mess != null)
                        {
                            Console.WriteLine($"Mess Details: ID: {mess.Id}, Name: {mess.Name}, Address: {mess.Adress}, Phone: {mess.PhoneNumber}, Email: {mess.Email}");
                        }
                        else
                        {
                            Console.WriteLine("Mess not found.");
                        }
                        break;

                    case "9": // Exit
                        exit = true;
                        Console.WriteLine("Exiting Mess Management System.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

        }
    }
}
