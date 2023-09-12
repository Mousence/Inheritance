#include <iostream>
#include <fstream>
#include "Inheritance.h"

using namespace std;

#define delimiter  "\n///-----------------------------------------------------------------------------------------------------///\n"

void print(Human* group[], const int n);
void save(Human* group[], const int n, const char sz_filemane[]);

//#define INHERITANCE_CHECK

void main()
{
	setlocale(LC_ALL, "");
#ifdef INHERITANCE_CHECK
	Human human("Montana", "Antomio", 25);
	human.print();

	Student student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
	student.print();

	Teacher teacher("White", "Walter", 50, "Chemistry", 20);
	teacher.print();

	Graduate graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg");
	graduate.print();
#endif // INHERITANCE_CHECK

	Human* group[] =
	{
		new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
		new Teacher("White", "Walter", 50, "Chemistry", 20),
		new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg")
	};
	print(group, sizeof(group) / sizeof(group[0]));
	
	for (int i = 0; i < sizeof(group) / sizeof(group[0]); i++) {
		delete group[i];
	}

}

void save(Human* group[], const int n, const char sz_filemane[]) {
	std::ofstream fout(sz_filemane);

	fout.close();
}