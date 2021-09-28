using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment
{
    public class Hostel
    {
        private Student[] studentList;
        public Student[] StudentList
        { get { return studentList; } }

        private int numOfStudent;
        public int NumOfStudent
        { get { return numOfStudent; } }

        public void AddStudent(Student aStudent)
        {
            studentList[numOfStudent] = aStudent;
            numOfStudent++;
        }

        public readonly int MAX_NUMBER_OF_STUDENT = 32;

        public string FindRoomAvailability(string floorNum, int roomNum)
        {
            bool roomNotAvailable = false;
            for(int i=0;i<NumOfStudent;i++)
            {
                if (StudentList[i].R.FloorNumber == floorNum && Convert.ToInt32(StudentList[i].R.RoomNumber) == roomNum)
                {
                    roomNotAvailable = true;
                    break;
                }
            }

            if (roomNotAvailable)
                return "not available";
            else
                return "available";
        }

        public bool CheckDuplicateRegNumber(string aRegNumber)
        {
            bool duplicateRegNumberFound = false;
            for(int i=0;i<numOfStudent;i++)
            {
                if (StudentList[i].RegNumber == aRegNumber)
                {
                    duplicateRegNumberFound = true;
                    break;
                }
            }

            return duplicateRegNumberFound;
        }

        public string GetStudentListTitle()
        {
            string listTitle;

            listTitle = string.Format("{0,-4}", "No");
            listTitle += string.Format("{0,-35}", "Name");
            listTitle += string.Format("{0,-20}", "Registration Number");
            listTitle += string.Format("{0,-22}", "Academic Year");
            listTitle += string.Format("{0,-15}", "Semester");
            listTitle += string.Format("{0,-10}", "Floor");
            listTitle += string.Format("{0,-5}", "Room\n");

            return listTitle;
        }

        public int[] FindStudentsByName(string keyword)
        {
            ArrayList temp = new ArrayList(); 
            int numOfStudentFound = 0;
            int[] indexOfStudentFound;

            for (int i=0;i<numOfStudent;i++)
            {
                if (studentList[i].Name.ToLower().IndexOf(keyword.ToLower()) != -1)
                {
                    temp.Add(i);
                    numOfStudentFound++;
                }
            }

            indexOfStudentFound = new int[numOfStudentFound];
            for (int i = 0; i < numOfStudentFound; i++)
                indexOfStudentFound[i] = (int)temp[i];

            return indexOfStudentFound;
        }

        public int[] FindStudentsByRegNumber(string keyword)
        {
            ArrayList temp = new ArrayList();
            int numOfStudentFound = 0;
            int[] indexOfStudentFound;

            for (int i = 0; i < numOfStudent; i++)
            {
                if (studentList[i].RegNumber.IndexOf(keyword) != -1)
                {
                    temp.Add(i);
                    numOfStudentFound++;
                }
            }

            indexOfStudentFound = new int[numOfStudentFound];
            for (int i = 0; i < numOfStudentFound; i++)
                indexOfStudentFound[i] = (int)temp[i];

            return indexOfStudentFound;
        }

        public string GetStudentList()
        {
            string listText = "";

            for (int i = 0; i < NumOfStudent; i++)
            {
                listText += string.Format("{0,-4}", i + 1);
                listText += string.Format("{0,-35}", StudentList[i].Name);
                listText += string.Format("{0,-20}", StudentList[i].RegNumber);
                listText += string.Format("{0,-22}", StudentList[i].Year);
                listText += string.Format("{0,-15}", StudentList[i].Sem);
                listText += string.Format("{0,-10}", StudentList[i].R.FloorNumber);
                listText += string.Format("{0,-1}", StudentList[i].R.RoomNumber + "\n");
            }

            return listText;
        }

        public string GetStudentList(int[] indexOfStudentList)
        {
            string listText = "";

            for (int j = 0; j < indexOfStudentList.Length; j++)
            {
                for (int i = 0; i < NumOfStudent; i++)
                {
                    if (i == indexOfStudentList[j])
                    {
                        listText += string.Format("{0,-4}", j+1);
                        listText += string.Format("{0,-35}", StudentList[i].Name);
                        listText += string.Format("{0,-20}", StudentList[i].RegNumber);
                        listText += string.Format("{0,-22}", StudentList[i].Year);
                        listText += string.Format("{0,-15}", StudentList[i].Sem);
                        listText += string.Format("{0,-10}", StudentList[i].R.FloorNumber);
                        listText += string.Format("{0,-1}", StudentList[i].R.RoomNumber + "\n");
                    }
                }
            }

            return listText;
        }

        public Hostel()
        {
            numOfStudent = 0;
            studentList = new Student[MAX_NUMBER_OF_STUDENT];
        }
    }
}
