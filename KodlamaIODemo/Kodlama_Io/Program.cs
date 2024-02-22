using Kodlama_Io.Business.Abstract;
using Kodlama_Io.Business.Concrete;
using Kodlama_Io.DataAccess.Concrete;
using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io
{
    internal class Program
    {
        private static IInstructorBusiness instructorBusiness = new InstructorManager(new InstructorDal());
        private static ICategoryBusiness categoryBusiness = new CategoryManager(new CategoryDal());
        private static ICourseBusiness courseBusiness = new CourseManager(new CourseDal());

        static void Main(string[] args)
        {
            bool isExit = false;
            Console.WriteLine("----***Welcome to Kodlama.Io Demo---****");
            while (!isExit)
            {
                ShowEntitySelection();
                string input = Console.ReadLine().ToUpper();
                string operationInput;
                switch (input)
                {
                    case "Q":
                        Console.WriteLine("Demo ended....");
                        isExit = true;
                        break;
                    case "1":
                        ShowOperations(1);
                        operationInput = Console.ReadLine();
                        DoOperation(operationInput, 1);
                        break;
                    case "2":
                        ShowOperations(1);
                        operationInput = Console.ReadLine();
                        DoOperation(operationInput, 2);
                        break;
                    case "3":
                        ShowOperations(2);
                        operationInput = Console.ReadLine();
                        DoOperation(operationInput, 3);
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
            Console.WriteLine("Click any buton for end");
            Console.ReadLine();
        }

        private static void DoOperation(string input, int type)
        {
            string idStr;
            int id;
            string name;
            if (type == 1)
            {
                string fName;
                string lName;
                switch (input)
                {
                    case "0":
                        ShowInstructor();
                        break;
                    case "1":
                        Console.WriteLine("Enter First Name");
                        fName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        lName = Console.ReadLine();
                        Console.WriteLine("Enter Id: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            InstructorAdd(fName, lName, id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "2":
                        ShowInstructor();
                        Console.WriteLine("Select Which Instructor will be removed: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            InstructorDelete(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "3":
                        ShowInstructor();
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        Console.WriteLine("Enter First Name");
                        fName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        lName = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            InstructorUpdate(id, fName, lName);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            GetInstructorById(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.ReadLine();
            }
            else if (type == 2)
            {
                switch (input)
                {
                    case "0":
                        ShowCategories();
                        break;
                    case "1":
                        Console.WriteLine("Enter Category Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Id: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            CategoryAdd(name, id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "2":
                        ShowCategories();
                        Console.WriteLine("Select Which Category will be removed: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            CategoryDelete(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "3":
                        ShowCategories();
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        Console.WriteLine("Enter Category Name");
                        name = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            CategoryUpdate(id, name);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            GetCategoryById(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.ReadLine();
            }
            else
            {
                string description;
                string language;
                int cid;
                int iid;
                switch (input)
                {
                    case "0":
                        ShowCourse();
                        break;
                    case "1":
                        Console.WriteLine("Enter Course Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Course Description");
                        description = Console.ReadLine();
                        Console.WriteLine("Enter Course Language");
                        language = Console.ReadLine();
                        Console.WriteLine("Enter Category Id: ");
                        idStr = Console.ReadLine();
                        if (!int.TryParse(idStr, out cid))
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        Console.WriteLine("Enter Instructor Id: ");
                        idStr = Console.ReadLine();
                        if (!int.TryParse(idStr, out iid))
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        Console.WriteLine("Enter Id: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            CourseAdd(name, description, language, id, cid, iid);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "2":
                        ShowCourse();
                        Console.WriteLine("Select Which Course will be removed: ");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            CourseDelete(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "3":
                        ShowCourse();
                        Console.WriteLine("Select Course Id: ");
                        idStr = Console.ReadLine();
                        if (!int.TryParse(idStr, out id))
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        Console.WriteLine("Enter Course Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Course Description");
                        description = Console.ReadLine();
                        Console.WriteLine("Enter Course Language");
                        language = Console.ReadLine();
                        Console.WriteLine("Enter Category Id: ");
                        idStr = Console.ReadLine();
                        if (!int.TryParse(idStr, out cid))
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        Console.WriteLine("Enter Instructor Id: ");
                        idStr = Console.ReadLine();
                        if (!int.TryParse(idStr, out iid))
                        {
                            Console.WriteLine("İnvalid Id ");
                        }

                        CourseUpdate(name, description, language, id, cid, iid);
                        break;
                    case "4":
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            GetCourseById(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            GetCourseCategory(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Select Id");
                        idStr = Console.ReadLine();
                        if (int.TryParse(idStr, out id))
                        {
                            GetCourseByInstructor(id);
                        }
                        else
                        {
                            Console.WriteLine("İnvalid Id ");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.ReadLine();
            }
        }

        private static void ShowEntitySelection()
        {
            Console.WriteLine("Select an Entity for the Database Operation: ");
            Console.WriteLine("1-Instructor");
            Console.WriteLine("2-Category");
            Console.WriteLine("3-Course");
            Console.WriteLine("Q-Exit");
        }

        private static void ShowOperations(int entity)
        {
            Console.WriteLine("Select an Operation: ");
            switch (entity)
            {
                case 1:
                    Console.WriteLine("0-List");
                    Console.WriteLine("1-Add");
                    Console.WriteLine("2-Delete");
                    Console.WriteLine("3-Update");
                    Console.WriteLine("4-GetById");
                    break;
                case 2:
                    Console.WriteLine("0-List");
                    Console.WriteLine("1-Add");
                    Console.WriteLine("2-Delete");
                    Console.WriteLine("3-Update");
                    Console.WriteLine("4-GetById");
                    Console.WriteLine("5-ListByCategory");
                    Console.WriteLine("6-ListByInstructor");
                    break;
            }

        }


        private static void ShowInstructor()
        {
            Console.WriteLine("------Instructor List---------");
            var list = instructorBusiness.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine("id: {0}, Instructor Name: {1} {2}", item.Id, item.FirstName, item.LastName);
            }
        }
        private static void InstructorAdd(string name, string lastname, int id)
        {
            ShowInstructor();
            instructorBusiness.Add(new Instructor { Id = id, FirstName = name, LastName = lastname });
            Console.WriteLine("------New Instructor Added---------");
            ShowInstructor();
        }
        private static void InstructorDelete(int id)
        {
            ShowInstructor();
            instructorBusiness.Delete(id);
            Console.WriteLine("------Selected Instructor Removed---------");
            ShowInstructor();
        }

        private static void InstructorUpdate(int id, string name, string lastname)
        {
            Instructor instructor = new Instructor();
            instructor.Id = id;
            instructor.FirstName = name;
            instructor.LastName = lastname;
            instructorBusiness.Update(instructor);
            Console.WriteLine("------Selected Instructor Updated---------");
            ShowInstructor();
        }

        private static void GetInstructorById(int id)
        {
            var item = instructorBusiness.Get(id);
            Console.WriteLine("id: {0}, Instructor Name: {1} {2}", item.Id, item.FirstName, item.LastName);
        }

        private static void ShowCategories()
        {
            Console.WriteLine("------Category List---------");
            var list = categoryBusiness.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine("id: {0}, Category Name: {1}", item.Id, item.CategoryName);
            }
        }
        private static void CategoryAdd(string name, int id)
        {
            ShowCategories();
            categoryBusiness.Add(new Category { Id = id, CategoryName = name });
            Console.WriteLine("------New Category Added---------");
            ShowCategories();
        }
        private static void CategoryDelete(int id)
        {
            ShowCategories();
            categoryBusiness.Delete(id);
            Console.WriteLine("------Selected Category Removed---------");
            ShowCategories();
        }

        private static void CategoryUpdate(int id, string name)
        {
            Category category = new Category();
            category.Id = id;
            category.CategoryName = name;
            categoryBusiness.Update(category);
            Console.WriteLine("------Selected Category Updated---------");
            ShowCategories();
        }

        private static void GetCategoryById(int id)
        {
            var item = categoryBusiness.Get(id);
            Console.WriteLine("id: {0}, Category Name: {1}", item.Id, item.CategoryName);
        }

        private static void ShowCourse()
        {
            Console.WriteLine("------Course List---------");
            var list = courseBusiness.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine("id: {0}, Instructor Id: {1},  Category Id: {2}," +
                    "Course name: {3}, Description: {4}, Language: {5}", item.Id, item.InstructorId, item.CategoryId, item.CourseName, item.Description, item.Language);
            }
        }
        private static void CourseAdd(string name, string description, string Language, int id, int cid, int iid)
        {
            ShowCourse();
            courseBusiness.Add(new Course { Id = id, CourseName = name, Description = description, Language = Language, CategoryId = cid, InstructorId = iid });
            Console.WriteLine("------New Course Added---------");
            ShowCourse();
        }
        private static void CourseDelete(int id)
        {
            ShowCourse();
            courseBusiness.Delete(id);
            Console.WriteLine("------Selected Course Removed---------");
            ShowCourse();
        }

        private static void CourseUpdate(string name, string description, string Language, int id, int cid, int iid)
        {
            Course course = new Course
            {
                Id = id,
                CourseName = name,
                Description = description,
                Language = Language,
                CategoryId = cid,
                InstructorId = iid
            };
            courseBusiness.Update(course);
            Console.WriteLine("------Selected Course Updated---------");
            ShowCourse();
        }

        private static void GetCourseById(int id)
        {
            var item = courseBusiness.Get(id);
            Console.WriteLine("id: {0}, Instructor Id: {1},  Category Id: {2}," +
                    "Course name: {3}, Description: {4}, Language: {5}", item.Id, item.InstructorId, item.CategoryId, item.CourseName, item.Description, item.Language);
        }

        private static void GetCourseCategory(int id)
        {
            Console.WriteLine("------Course By Category id:{0} List---------", id);
            var list = courseBusiness.GetCourseCategory(id);
            foreach (var item in list)
            {
                Console.WriteLine("id: {0}, Instructor Id: {1},  Category Id: {2}," +
                    "Course name: {3}, Description: {4}, Language: {5}", item.Id, item.InstructorId, item.CategoryId, item.CourseName, item.Description, item.Language);
            }
        }

        private static void GetCourseByInstructor(int id)
        {
            Console.WriteLine("------Course By Instructor id:{0} List---------", id);
            var list = courseBusiness.GetCourseInstructor(id);
            foreach (var item in list)
            {
                Console.WriteLine("id: {0}, Instructor Id: {1},  Category Id: {2}," +
                    "Course name: {3}, Description: {4}, Language: {5}", item.Id, item.InstructorId, item.CategoryId, item.CourseName, item.Description, item.Language);
            }
        }
    }
    }

