# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.13

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

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Users\Pasha Eagle\AppData\Local\JetBrains\Toolbox\apps\CLion\ch-0\183.4588.63\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Users\Pasha Eagle\AppData\Local\JetBrains\Toolbox\apps\CLion\ch-0\183.4588.63\bin\cmake\win\bin\cmake.exe" -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05"

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug"

# Include any dependencies generated for this target.
include CMakeFiles/lab05.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/lab05.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/lab05.dir/flags.make

CMakeFiles/lab05.dir/main.cpp.obj: CMakeFiles/lab05.dir/flags.make
CMakeFiles/lab05.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir="C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug\CMakeFiles" --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/lab05.dir/main.cpp.obj"
	C:\PROGRA~1\MINGW-~1\X86_64~1.0-P\mingw64\bin\X86_64~2.EXE  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\lab05.dir\main.cpp.obj -c "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\main.cpp"

CMakeFiles/lab05.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/lab05.dir/main.cpp.i"
	C:\PROGRA~1\MINGW-~1\X86_64~1.0-P\mingw64\bin\X86_64~2.EXE $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\main.cpp" > CMakeFiles\lab05.dir\main.cpp.i

CMakeFiles/lab05.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/lab05.dir/main.cpp.s"
	C:\PROGRA~1\MINGW-~1\X86_64~1.0-P\mingw64\bin\X86_64~2.EXE $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\main.cpp" -o CMakeFiles\lab05.dir\main.cpp.s

# Object files for target lab05
lab05_OBJECTS = \
"CMakeFiles/lab05.dir/main.cpp.obj"

# External object files for target lab05
lab05_EXTERNAL_OBJECTS =

lab05.exe: CMakeFiles/lab05.dir/main.cpp.obj
lab05.exe: CMakeFiles/lab05.dir/build.make
lab05.exe: CMakeFiles/lab05.dir/linklibs.rsp
lab05.exe: CMakeFiles/lab05.dir/objects1.rsp
lab05.exe: CMakeFiles/lab05.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir="C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug\CMakeFiles" --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable lab05.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\lab05.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/lab05.dir/build: lab05.exe

.PHONY : CMakeFiles/lab05.dir/build

CMakeFiles/lab05.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\lab05.dir\cmake_clean.cmake
.PHONY : CMakeFiles/lab05.dir/clean

CMakeFiles/lab05.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05" "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05" "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug" "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug" "C:\Users\Pasha Eagle\Documents\Sharaga\Sharaga\Sharaga_3kurs\OOP\me\labs\c++\lab05\cmake-build-debug\CMakeFiles\lab05.dir\DependInfo.cmake" --color=$(COLOR)
.PHONY : CMakeFiles/lab05.dir/depend

