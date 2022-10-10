# The-Mad-Chemist #

Class Group Project

Our team wrote a program that calculates the atomic weight of simple molecules. The user provides a chemical formula like "NaCl" as a command line parameter. Our program calculates the weight of the molecule based on the weights of the individual atoms (found in the periodic table). The periodic table is provided for our program as a text file.

When our program first begins, we do not know the identitity of the individual atoms in the molecular formula. It parses the molecular formula by breaking it apart into individual atoms and the count of each atom. Once the identity of each atom is known, the program looks up the masses in the periodic table and calculates the mass of the entire molecule.

The class was divided up into three teams and each team was given an API specification and completed a different part of the project. At the end, all of the modules were brought together into a program for parsing chemical formulas. Our specific role was the string parsing and it was considered the most challenging portion of the project.

Unit Testing: Our team created a simple program that tests the functionality of our CalculateMass library. Our unit test program attempts to calculate a variety of molecules that include single-letter elements and multiple-letter elements. It looks up molecules that include single atoms, like "NaCl", and also molecules that contain more than one of the same atom, like "Na3PO4".

Testing Without the Periodic Table Library: Until our teamates finished their PeriodicTable library, we were unable to lookup the actual weight of each element. Instead, we had our program print out the atomic symbol and count of each unique element in the molecular formula to check that the program was parsing the formula correctly, even without access to the periodic table.
