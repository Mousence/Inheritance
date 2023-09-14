#include "Inheritance.h"

	const std::string& Human::get_last_name()const {
		return last_name;
	}
	const std::string& Human::get_first_name()const {
		return first_name;
	}
	int  Human::get_age()const {
		return age;
	}
	void  Human::set_last_name(const std::string& last_name) {
		this->last_name = last_name;
	}
	void  Human::set_first_name(const std::string& first_name) {
		this->first_name = first_name;
	}
	void  Human::set_age(int age) {
		this->age = age;
	}

	//					Constructors:
	Human::Human(HUMAN_TAKE_PARAMETERS) {
		set_last_name(last_name);
		set_first_name(first_name);
		set_age(age);
		cout << "HConstructor:\t" << this << endl;
	}
	Human::~Human() {
		cout << "HDestructor:\t" << this << endl;
	}
	std::ostream& Human::print(std::ostream& os) const {
		return os << last_name << " " << first_name << " " << age << " y/o ";
	}
	std::ofstream& Human::print(std::ofstream& ofs) const {
		ofs.width(LAST_NAME_WIDTH);
		ofs << std::left;
		ofs << last_name;
		ofs.width(FIRST_NAME_WIDTH);
		ofs << std::left;
		ofs << first_name;
		ofs.width(AGE_WIDTH);
		ofs << age;
	  return ofs;
	}

	std::ostream& operator<<(std::ostream& os, const Human& obj) {
		return obj.print(os);
	}
	std::ofstream& operator<<(std::ofstream& ofs, const Human& obj) {
		obj.print(ofs);
		return ofs;
	}
	
	const std::string& Student::get_speciality()const {
		return speciality;
	}
	const std::string& Student::get_group()const {
		return group;
	}
	double Student::get_rating()const {
		return rating;
	}
	double Student::get_attendance()const {
		return attendance;
	}
	void Student::set_speciality(const std::string& speciality) {
		this->speciality = speciality;
	}
	void Student::set_group(const std::string& group) {
		this->group = group;
	}
	void Student::set_rating(double rating) {
		this->rating = rating;
	}
	void Student::set_attendance(double attendance) {
		this->attendance = attendance;
	}
	std::ostream& operator<<(std::ostream& os, const Student& obj) {
		return obj.print(os);
	}


	//					Constructors:
	Student::Student(HUMAN_TAKE_PARAMETERS, STUDENT_TAKE_PARAMETERS) :Human(HUMAN_GIVE_PARAMETERS) {
		set_speciality(speciality);
		set_group(group);
		set_rating(rating);
		set_attendance(attendance);
		cout << "SConstructor:\t" << this << endl;
	}
	Student::~Student() {
		cout << "SDestructor:\t" << this << endl;
	}

	std::ostream& Student::print(std::ostream& os) const {
		return Human::print(os) << speciality << " " << group << " " << rating << " " << attendance;
	}
	std::ofstream& Student::print(std::ofstream& ofs) const {
		Human::print(ofs);
		ofs.width(SPECIALITY_WIDTH);
		ofs << speciality;
		ofs.width(GROUP_WIDTH);
		ofs << group;
		ofs.width(RATING_WIDTH);
		ofs << rating;
		ofs.width(ATTANDANCE_WIDTH);
		ofs << attendance;
		return ofs;
	}

	const std::string& Teacher::get_speciality()const {
		return speciality;
	}
	int Teacher::get_experience()const {
		return experience;
	}
	void Teacher::set_speciality(const std::string& speciality) {
		this->speciality = speciality;
	}
	void Teacher::set_experience(int experience) {
		this->experience = experience;
	}
	Teacher::Teacher(HUMAN_TAKE_PARAMETERS, TEACHER_TAKE_PARAMETERS) :Human(HUMAN_GIVE_PARAMETERS) {
		set_speciality(speciality);
		set_experience(experience);
		cout << "TConstructor:\t" << this << endl;
	}

	std::ostream& Teacher::print(std::ostream& os) const {
		return Human::print(os) << speciality << " " << experience << " years";
	}
	std::ofstream& Teacher::print(std::ofstream& ofs) const {
		Human::print(ofs);
	    ofs.width(SPECIALITY_WIDTH);
		ofs << speciality;
		ofs.width(EXPERIENCE_WIDTH);
		ofs << experience;
		return ofs;
	}
	std::ostream& operator<<(std::ostream& os, const Teacher& obj) {
		return obj.print(os);
	}

	const std::string& Graduate::get_subject()const {
		return subject;
	}
	void Graduate::set_subject(const std::string& subject) {
		this->subject = subject;
	}


	Graduate::Graduate(HUMAN_TAKE_PARAMETERS, STUDENT_TAKE_PARAMETERS, const std::string& subject)
		:Student(HUMAN_GIVE_PARAMETERS, STUDENT_GIVE_PARAMETERS) {
		set_subject(subject);
		cout << "GConstructor:\t" << this << endl;
	}
	Graduate::~Graduate() {
		cout << "GDestructor:\t" << this << endl;
	}

	std::ostream& Graduate::print(std::ostream& os) const {
		return Student::print(os) << " " << subject;
	}
	std::ofstream& Graduate::print(std::ofstream& ofs) const {
		Human::print(ofs) << " " << subject;
		return ofs;
	}
	std::ostream& operator<<(std::ostream& os, const Graduate& obj) {
		return obj.print(os);
	}


	void print(Human* group[], const int n) {
		cout << delimiter << endl;
		for (int i = 0; i < n; i++)
		{
			cout << typeid(*group[i]).name() << ":\t";
			if (typeid(*group[i]) == typeid(Student))	cout << *dynamic_cast<Student*>(group[i]) << endl;
			if (typeid(*group[i]) == typeid(Graduate))	cout << *dynamic_cast<Graduate*>(group[i]) << endl;
			if (typeid(*group[i]) == typeid(Teacher))	cout << *dynamic_cast<Teacher*>(group[i]) << endl;
			//cout << group[i] << endl;
			cout << delimiter << endl;
		}
	}