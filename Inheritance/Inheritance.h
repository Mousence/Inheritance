#pragma once

#include<iostream>
#include<fstream>
#include<string>
using namespace std;

#define delimiter  "\n///-----------------------------------------------------------------------------------------------------///\n"

#define HUMAN_TAKE_PARAMETERS const std::string& last_name, const std::string& first_name, int age
#define HUMAN_GIVE_PARAMETERS last_name, first_name, age

class Human {
	static const int LAST_NAME_WIDTH = 15; //����������� ����� ������
	static const int FIRST_NAME_WIDTH = 15;
	static const int AGE_WIDTH = 3;
	std::string last_name;
	std::string first_name;
	int age;
public:
	const std::string& get_last_name()const;
	const std::string& get_first_name()const;
	int get_age()const;
	void set_last_name(const std::string& last_name);
	void set_first_name(const std::string& first_name);
	void set_age(int age);

	//					Constructors:
	Human(HUMAN_TAKE_PARAMETERS);
	virtual ~Human();
	virtual std::ostream& print(std::ostream& os)const;
	virtual std::ofstream& print(std::ofstream& ofs)const;

	virtual std::ifstream& scan(std::ifstream& ifs);
};

std::ostream& operator<<(std::ostream& os, const Human& obj);
std::ofstream& operator<<(std::ofstream& ofs, const Human& obj);
std::ifstream& operator>>(std::ifstream& ifs, Human& obj);

#define STUDENT_TAKE_PARAMETERS	const std::string& speciality, const std::string& group, double rating, double attendance
#define STUDENT_GIVE_PARAMETERS	speciality, group, rating, attendance
class Student :public Human
{
	static const int SPECIALITY_WIDTH = 25;
	static const int GROUP_WIDTH = 8;
	static const int RATING_WIDTH = 8;
	static const int ATTANDANCE_WIDTH = 8;
	std::string speciality;
	std::string group;
	double rating;
	double attendance;
public:
	const std::string& get_speciality()const;
	const std::string& get_group()const;
	double get_rating()const;
	double get_attendance()const;
	void set_speciality(const std::string& speciality);
	void set_group(const std::string& group);
	void set_rating(double rating);
	void set_attendance(double attendance);

	//					Constructors:
	Student(HUMAN_TAKE_PARAMETERS, STUDENT_TAKE_PARAMETERS);
	~Student();

	std::ostream& print(std::ostream& os) const override;
	std::ofstream& print(std::ofstream& ofs) const override;
	std::ifstream& scan(std::ifstream& ifs);
};
std::ostream& operator<<(std::ostream& os, const Student& obj);

#define TEACHER_TAKE_PARAMETERS const std::string& speciality, int experience
#define TEACHER_GIVE_PARAMETERS speciality, experience
class Teacher :public Human
{
	static const int SPECIALITY_WIDTH = 25;
	static const int EXPERIENCE_WIDTH = 3;
	std::string speciality;
	int experience;
public:
	const std::string& get_speciality()const;
	int get_experience()const;
	void set_speciality(const std::string& speciality);
	void set_experience(int experience);
	Teacher(HUMAN_TAKE_PARAMETERS, TEACHER_TAKE_PARAMETERS);

	std::ostream& print(std::ostream& os) const override;
	std::ofstream& print(std::ofstream& ofs) const override;
	std::ifstream& scan(std::ifstream& ifs)override;
};
std::ostream& operator<<(std::ostream& os, const Teacher& obj);


class Graduate :public Student
{
	static const int SUBJECT_WIDTH = 50;
	std::string subject;
public:
	const std::string& get_subject()const;
	void set_subject(const std::string& subject);

	Graduate(HUMAN_TAKE_PARAMETERS, STUDENT_TAKE_PARAMETERS, const std::string& subject);
	~Graduate();
	virtual std::ostream& print(std::ostream& os) const override;
	std::ofstream& print(std::ofstream& ofs) const override;
	std::ifstream& scan(std::ifstream& ifs) override;
};
std::ostream& operator<<(std::ostream& os, const Graduate& obj);

void print(Human* group[], const int n);
