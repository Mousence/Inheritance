#include <iostream>
#include "Inheritance.h"
using namespace std;

#define delimiter cout << "///-----------------------------------------------------------------------------------------------------///" << endl;

void main()
{
	setlocale(LC_ALL, "");

	Human* group[] = {
		new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
		new Teacher("White", "Walter", 50, "Chemistry", 20),
		new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg"),
	};
	delimiter
	for (int i = 0; i < sizeof(group) / sizeof(group[0]); i++) {
		group[i]->print();
		delimiter
	}
}