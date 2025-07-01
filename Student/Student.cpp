#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <algorithm>
#include <cctype> // для isalpha, isspace

using namespace std;

class Student {
public:
    string fullName;
    string specialty;
    string groupNumber;
    double averageScore;

    // Метод для ввода данных студента с проверками
    void input() {
        cin.ignore(); // Очистка буфера

        // Ввод ФИО с проверкой (только буквы и пробелы)
        do {
            cout << "Введите ФИО: ";
            getline(cin, fullName);
            if (isValidName(fullName)) break;
            cout << "Ошибка: ФИО должно содержать только буквы и пробелы!" << endl;
        } while (true);

        // Ввод специальности
        cout << "Введите специальность: ";
        getline(cin, specialty);

        // Ввод номера группы
        cout << "Введите номер группы: ";
        getline(cin, groupNumber);

        // Ввод среднего балла с проверкой
        do {
            cout << "Введите средний балл (от 1 до 5): ";
            cin >> averageScore;
            if (averageScore >= 1 && averageScore <= 5) break;
            cout << "Ошибка: Средний балл должен быть от 1 до 5!" << endl;
        } while (true);

        cin.ignore(); // Игнорируем '\n' после числа
    }

    // Проверка ФИО (буквы и пробелы)
    bool isValidName(const string& name) const {
        for (char ch : name) {
            if (!isalpha(ch) && !isspace(ch)) return false;
        }
        return !name.empty();
    }

    // Метод для вывода информации о студенте
    void print() const {
        cout << "ФИО: " << fullName << endl;
        cout << "Специальность: " << specialty << endl;
        cout << "Группа: " << groupNumber << endl;
        cout << "Средний балл: " << averageScore << endl;
        cout << "-----------------------------" << endl;
    }

    // Статические методы работы со списком студентов

    static void addStudent(vector<Student>& students) {
        Student s;
        s.input();
        students.push_back(s);
    }

    static void saveToFile(const vector<Student>& students, const string& filename) {
        ofstream fout(filename);
        if (!fout) {
            cout << "Ошибка открытия файла для записи!" << endl;
            return;
        }

        for (const auto& s : students) {
            fout << s.fullName << endl;
            fout << s.specialty << endl;
            fout << s.groupNumber << endl;
            fout << s.averageScore << endl;
        }

        fout.close();
        cout << "Данные успешно сохранены в файл." << endl;
    }

    static void loadFromFile(vector<Student>& students, const string& filename) {
        ifstream fin(filename);
        if (!fin) {
            cout << "Файл не найден!" << endl;
            return;
        }

        students.clear();

        Student s;
        while (getline(fin, s.fullName)) {
            getline(fin, s.specialty);
            getline(fin, s.groupNumber);
            fin >> s.averageScore;
            fin.ignore(); // Игнорируем '\n' после числа

            students.push_back(s);
        }

        fin.close();
        cout << "Данные успешно загружены из файла." << endl;
    }

    static void sortStudents(vector<Student>& students, int sortChoice) {
        if (sortChoice == 1) {
            sort(students.begin(), students.end(), [](const Student& a, const Student& b) {
                return a.averageScore < b.averageScore;
                });
        }
        else if (sortChoice == 2) {
            sort(students.begin(), students.end(), [](const Student& a, const Student& b) {
                return a.averageScore > b.averageScore;
                });
        }
    }

    static void printAll(const vector<Student>& students) {
        for (const auto& s : students) {
            s.print();
        }
    }
};

int main() {
    setlocale(LC_ALL, "Russian");

    vector<Student> students;
    int choice;

    do {
        cout << "\nМеню:\n";
        cout << "1. Добавить студента\n";
        cout << "2. Сохранить данные в файл\n";
        cout << "3. Загрузить данные из файла и отсортировать\n";
        cout << "4. Вывести список студентов\n";
        cout << "5. Выход\n";
        cout << "Выберите действие: ";
        cin >> choice;

        switch (choice) {
        case 1:
            Student::addStudent(students);
            break;

        case 2:
            Student::saveToFile(students, "students.txt");
            break;

        case 3: {
            Student::loadFromFile(students, "students.txt");

            cout << "Выберите способ сортировки:\n";
            cout << "1. По возрастанию среднего балла\n";
            cout << "2. По убыванию среднего балла\n";
            int sortChoice;
            cin >> sortChoice;

            Student::sortStudents(students, sortChoice);
            Student::printAll(students);
            break;
        }

        case 4:
            Student::printAll(students);
            break;

        case 5:
            cout << "Выход из программы." << endl;
            break;

        default:
            cout << "Неверный выбор. Попробуйте снова." << endl;
        }

    } while (choice != 5);

    return 0;
}