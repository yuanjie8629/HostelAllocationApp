# HostelAllocationApp
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-4-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->

## Overview
<p>Excellence College Hostel Allocation App is designed for staff to allocate rooms to students who apply for hostel accommodation.</p>
<p>Students are required to fill in their name, registration number, and year and semester of study on an application form to allow for admin staff to perform room allocation. By the end of each semester, all students currently occupying rooms in the hostel are required to vacate them. They need to apply for next semester room allocation again if they wish to stay in hostel.</p>
<p>Additionally, this application applies OOP approach.</p>
<p>The functions of the system are as follows:</p>

1. **Add** <br> The “Add” option is used to allocate room to students. Room allocation is performed on a semester basis. The college follows a two-semester system which means there are 2 semesters in each academic year. Prior to the start of each semester, students may apply for hostel rooms for the upcoming semester. All rooms in the hostel are limited to single occupancy and the design of each room are identical. There is a total of 4 floors with 8 rooms on each floor in the hostel. The floor is numbered from 1 to 4 while the room number for each floor is numbered from 1 to 8. By clicking on the “Add” button on the main page, the application will direct the admin staff to a new page which allows the admin staff to enter the information of students given and assign students to the room they requested. When a room is successfully allocated to a student, a confirmation message with student information will be shown at the page.<br><br>
2. **Delete** <br> The “Delete” option is used to remove a student from the room they’re assigned to given that the student wish to move out from hostel. By clicking the “delete” button, the application will direct the admin staff to a new page which has the complete list of students’ information with the respective room allocated to them. The admin will select the number of the student to be deleted according to the list. After selecting a number, the admin staff will then finish the deleting process by clicking on the “Delete” button below the page. A confirmation message will be shown at the page with student information when a student is successfully deleted from the list.<br><br>
3. **Modify** <br> The “Modify” option is used to modify and change information of students allocated in the hostel. When clicking the “Modify” button, the admin staff will be directed to a new page which has the complete list of students’ information with the respective room allocated to them. The admin will select the number of the student to be modify according to the list. Then, the admin staff will be prompted to tick the type of information they wish to edit (Name, Registration Number, Academic Year etc…). After the admin staff entered the new information, they will click on the “Modify” button below to finish the information modifying process. A confirmation message will be shown at the page with student information when a student’s information is successfully modified from the list. The staff can then return to the main page my simply clicking on the “Return” button below the page.<br><br>
4. **Search** <br> The “Search” option is used to search and find a student’s information from the list of students allocated in the hostel. By clicking on the “Search” button on the main page, the application will direct the admin staff to a new page which allow the staff to search keywords of student’s information according to either student’s name or registration number. After entering the keyword, the staff will have to click on the “Search” button to finish the searching process. List of students with the corresponding keyword will be shown on the page if available. The staff can then return to the main page my simply clicking on the “Return” button below the page.<br><br>
5. **List** <br> The “List” option is used to show the whole list of students allocated in the hostel. The admin staff will click on the “List” button on the main page to view the complete list. After clicking on the button, a new page will pop out to show the complete list. In addition to this, the list is arranged by the floor number and room number to make the list looks organized. The staff can return to the main page my simply clicking on the “Return” button below the page.<br><br>
6. **End of Semester** <br> The “End of Semester” checkbox is used when the admin staff wants to vacate all the students that are currently occupying rooms in the hostel by the end of the semester. After the checkbox is checked, it enables the user to click “Remove all students from Hostel” option. The “Remove all students from Hostel” option is used to delete all the allocation records. By clicking the option, a confirmation message form will be pop up to ask the user whether the user wants to delete all the allocation records or not. The allocation records will be deleted only when then user clicked the “Ok” button.<br><br>

## Tools
1. C#
2. Visual Studio 2019 (.NET desktop development)

## Usage
Import the files into your project.<br>
Open and run the project with Visual Studio (with .NET desktop development installed).

## Application Design
### Class Diagram
<img src="previews/ClassDiagram.png">

## Test
Manual testing has been performed.

## Previews
1. Main Menu <br> <img src="previews/MainMenu.png"><br><br>
2. Add <br> <img src="previews/Add.png"><br><br>
3. Delete <br> <img src="previews/Delete.png"><br><br>
4. Modify <br> <img src="previews/Modify.png"><br><br>
5. Search by Name <br> <img src="previews/SearchByName.png"><br><br>
6. Search by Registration Number <br> <img src="previews/SearchByRegNum.png"><br><br>
7. List <br> <img src="previews/List.png"><br><br>
8. End of Semester <br> <img src="previews/EndOfSemester.png"><br><br>

## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://github.com/yuanjie8629"><img src="https://avatars.githubusercontent.com/u/86699785?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Tan Yuan Jie</b></sub></a><br /><a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=yuanjie8629" title="Code">💻</a> <a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=yuanjie8629" title="Documentation">📖</a> <a href="#ideas-yuanjie8629" title="Ideas, Planning, & Feedback">🤔</a> <a href="#userTesting-yuanjie8629" title="User Testing">📓</a></td>
    <td align="center"><a href="https://github.com/lwleo02"><img src="https://avatars.githubusercontent.com/u/86616877?v=4?s=100" width="100px;" alt=""/><br /><sub><b>lwleo02</b></sub></a><br /><a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=lwleo02" title="Code">💻</a> <a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=lwleo02" title="Documentation">📖</a> <a href="#ideas-lwleo02" title="Ideas, Planning, & Feedback">🤔</a> <a href="#userTesting-lwleo02" title="User Testing">📓</a></td>
    <td align="center"><a href="https://github.com/threelittle87"><img src="https://avatars.githubusercontent.com/u/86560855?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Wo Zi Rock</b></sub></a><br /><a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=threelittle87" title="Code">💻</a> <a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=threelittle87" title="Documentation">📖</a> <a href="#ideas-threelittle87" title="Ideas, Planning, & Feedback">🤔</a> <a href="#userTesting-threelittle87" title="User Testing">📓</a></td>
    <td align="center"><a href="https://github.com/deviljin1009"><img src="https://avatars.githubusercontent.com/u/86699859?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Pang Jia Jin</b></sub></a><br /><a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=deviljin1009" title="Code">💻</a> <a href="https://github.com/yuanjie8629/HostelAllocationApp/commits?author=deviljin1009" title="Documentation">📖</a> <a href="#ideas-deviljin1009" title="Ideas, Planning, & Feedback">🤔</a> <a href="#userTesting-deviljin1009" title="User Testing">📓</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!