#include <iostream>
#include <fstream>
#include <istream>
#include <sstream>
#include <ostream>
#include <string>
#include "Inheritance.h"

using namespace std;

#define delimiter  "\n///-----------------------------------------------------------------------------------------------------///\n"
#define HUMAN_GET_PARAMETERS last_name >> first_name >> age
#define STUDENT_GET_PARAMETERS speciality >> group >> rating >> attendance
#define TEACHER_GET_PARAMETERS speciality >> experience
void print(Human* group[], const int n);
void save(Human* group[], const int n, const char sz_filename[]);
//void load(Human* group[], const int n, const char sz_filename[]);
Human* human_factory(const std::string & type);
Human** load(const char sz_filename[], int& n);

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

	Human* group[3];
	load(group, sizeof(group) / sizeof(group[0]), "group.txt");
	print(group, sizeof(group) / sizeof(group[0]));
#endif // INHERITANCE_CHECK

	int n = 0;
	Human** group = load("group.txt", n);
	print(group, n);

}

void save(Human* group[], const int n, const char sz_filename[]) {
	std::ofstream fout(sz_filename);

	for (int i = 0; i < n; i++) {
		fout << typeid(*group[i]).name() << ":\t";
		fout << *group[i] << endl;
	}
	fout.close();
	std::string command = "notepad ";
	command += sz_filename;
	system(command.c_str());
}

Human* human_factory(const std::string& type) {
	if (type.find("Student") != std::string::npos) return new Student("", "", 0, "", "", 0, 0);
	if (type.find("Student") != std::string::npos) return new Graduate("", "", 0, "", "", 0, 0, "");
	if (type.find("Student") != std::string::npos) return new Teacher("", "", 0, "", 0);
	return nullptr;
}
Human** load(const char sz_filename[], int& n) {
	n = 0;
	Human** group = nullptr;
	std::ifstream fin(sz_filename);
	if (fin.is_open()) {
		std::string buffer;
		while (!fin.eof()) {
			std::getline(fin, buffer);
			if (buffer.empty())continue;
			n++;
		}
		group = new Human * [n] {};

		cout << "Position:\t" << fin.tellg() << endl;
		fin.clear();
		fin.seekg(0);
		cout << "Position:\t" << fin.tellg() << endl;
		for (int i = 0; i < n; i++) {
			std::getline(fin, buffer, ':');
			group[i] = human_factory(buffer);
			if(group[i])
				fin >> group[i];
			//fin >> group[i];
		}

		fin.close();
	}
	else
		std::cerr << "Error: File doesnt exist!" << endl;

	return group;
}

/*
void load(Human* C_group[], const int n, const char sz_filename[]) {
	std::ifstream fin(sz_filename);
	if (fin.is_open()) {
		std::string line;

		std::string last_name;
		std::string first_name;
		int age;

		//std::string speciality;
		int experience;
		std::string subject;

		int i = 0;
		while (std::getline(fin, line)) {
			std::string Class;
			std::string Type;
			std::istringstream iss(line);
			iss >> Class >> Type;
			if (Type == "Student:") {
				std::string speciality;
				std::string group;
				double rating;
				double attendance;
				iss >> HUMAN_GET_PARAMETERS >> STUDENT_GET_PARAMETERS;
				C_group[i] = new Student(HUMAN_GIVE_PARAMETERS, STUDENT_GIVE_PARAMETERS);
			}
			else if (Type == "Teacher:") {
				std::string speciality;
				int experience;
				iss >> HUMAN_GET_PARAMETERS >> TEACHER_GET_PARAMETERS;
				C_group[i] = new Teacher(HUMAN_GIVE_PARAMETERS, TEACHER_GIVE_PARAMETERS);
			}
			else if (Type == "Graduate:") {
				std::string speciality;
				std::string group;
				double rating;
				double attendance;

				std::string subject;
				iss >> HUMAN_GET_PARAMETERS >> STUDENT_GET_PARAMETERS >> subject;
				C_group[i] = new Graduate(HUMAN_GIVE_PARAMETERS, STUDENT_GIVE_PARAMETERS, subject);
			}
			i++;
		}
	}
	else {
		std::cerr << "Error: File doesnt exist!" << endl;
	}
	fin.close();
} */