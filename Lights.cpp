#include <iostream>
#include <string>
using namespace std;

int main() {
	cout << "Do you want the lights on? (y/n) : ";
	string lightState;
	getline(cin, lightState);
	system("cls");
	while (lightState != "y" && lightState != "n") {
		cout << "Invalid!\n\n";
		cout << "Do you want the lights on? (y/n)\n"
			 << "You can only use y or n.\n";			 
		getline(cin, lightState);
		system("cls");
	}
	if (lightState == "y") {
		cout << "The lights turned on";
	}
	else if (lightState == "n") {
		cout << "The lights turned off";
	}
}