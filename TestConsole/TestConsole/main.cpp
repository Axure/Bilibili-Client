#include <iostream>

int main()
{
	int prevent_end;
	char buffer[5];
	std::cin >> *buffer;
	std::cout << *buffer << std::endl;
	std::cout << "I am fucking you!";
	std::cin >> *buffer;
	getchar();
	std::cin >> prevent_end; // std::cin is buffer safe.
	return 0;
}