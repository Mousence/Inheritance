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
	void Human::print()const {
		cout << last_name << " " << first_name << " " << age << " y/o\n";
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

	std::ostream& operator<<(std::ostream& os, const Human& obj) {
		return os <<(Human&)obj << obj.get_last_name() << " " << obj.get_first_name() << " " << obj.get_age() << " лет" << endl;
	}
	std::ostream& operator<<(std::ostream& os, const Student& obj) {
		return os << (Human&)obj << obj.get_last_name() << " " << obj.get_first_name() << " " << obj.get_age() << " лет" << endl;
	}
	std::ostream& operator<<(std::ostream& os, const Teacher& obj) {
		return os << (Human&)obj << obj.get_last_name() << " " << obj.get_first_name() << " " << obj.get_age() << " лет" << endl;
	}
	std::ostream& operator<<(std::ostream& os, const Graduate& obj) {
		return os << (Human&)obj << obj.get_last_name() << " " << obj.get_first_name() << " " << obj.get_age() << " лет" << endl;
	}

	void Student::print()const {
		Human::print();
		cout << speciality << " " << group << " " << rating << " " << attendance << endl;
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

	void Teacher::print()const {
		Human::print();
		cout << speciality << " " << experience << " years\n";
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
	void Graduate::print()const {
		Student::print();
		cout << subject << endl;
	}



	void print(Human* group[], const int n) {
		cout << delimiter << endl;
		for (int i = 0; i < n; i++)
		{
			cout << typeid(*group[i]).name() << endl;
			if (typeid(*group[i]) == typeid(Student)) cout << dynamic_cast<Student*>(group[i]) << endl;
			if (typeid(*group[i]) == typeid(Graduate)) cout << dynamic_cast<Graduate*>(group[i]) << endl;
			if (typeid(*group[i]) == typeid(Teacher)) cout << dynamic_cast<Teacher*>(group[i]) << endl;
			cout << *group[i] << endl;
			cout << delimiter << endl;
		}
	}