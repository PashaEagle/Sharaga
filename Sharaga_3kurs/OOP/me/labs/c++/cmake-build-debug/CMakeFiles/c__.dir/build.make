# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.13

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /home/pasha/.local/share/JetBrains/Toolbox/apps/CLion/ch-0/183.4588.63/bin/cmake/linux/bin/cmake

# The command to remove a file.
RM = /home/pasha/.local/share/JetBrains/Toolbox/apps/CLion/ch-0/183.4588.63/bin/cmake/linux/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/c__.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/c__.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/c__.dir/flags.make

CMakeFiles/c__.dir/main.cpp.o: CMakeFiles/c__.dir/flags.make
CMakeFiles/c__.dir/main.cpp.o: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/c__.dir/main.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/c__.dir/main.cpp.o -c /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/main.cpp

CMakeFiles/c__.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/c__.dir/main.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/main.cpp > CMakeFiles/c__.dir/main.cpp.i

CMakeFiles/c__.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/c__.dir/main.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/main.cpp -o CMakeFiles/c__.dir/main.cpp.s

# Object files for target c__
c___OBJECTS = \
"CMakeFiles/c__.dir/main.cpp.o"

# External object files for target c__
c___EXTERNAL_OBJECTS =

c__: CMakeFiles/c__.dir/main.cpp.o
c__: CMakeFiles/c__.dir/build.make
c__: CMakeFiles/c__.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable c__"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/c__.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/c__.dir/build: c__

.PHONY : CMakeFiles/c__.dir/build

CMakeFiles/c__.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/c__.dir/cmake_clean.cmake
.PHONY : CMakeFiles/c__.dir/clean

CMakeFiles/c__.dir/depend:
	cd /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++ /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++ /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug /home/pasha/Documents/Sharaga_3kurs/OOP/me/labs/c++/cmake-build-debug/CMakeFiles/c__.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/c__.dir/depend

