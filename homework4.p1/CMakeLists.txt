# Main cmake file 
# Homework 4 template

cmake_minimum_required(VERSION 2.6)

# Main project name is HW4_Program
project(HW4_Program)


set(CFILE_PATH  "${CMAKE_SOURCE_DIR}/../../SDK/cmake/")
set(CMAKE_MODULE_PATH "${CMAKE_SOURCE_DIR}/" ${CMAKE_MODULE_PATH} "${CMAKE_SOURCE_DIR}/../../SDK/cmake/")

message(STATUS "Source directory ${CMAKE_SOURCE_DIR}")
message(STATUS "SDK directory ${CMAKE_SOURCE_DIR}/../../SDK")


# Find packages
FIND_PACKAGE(glew REQUIRED)
FIND_PACKAGE(glm REQUIRED)
FIND_PACKAGE(glfw3 REQUIRED)
FIND_PACKAGE(OpenGL REQUIRED)


# Include dirs
include_directories(${GLEW_INCLUDE_DIR})
include_directories(${GLFW3_INCLUDE_DIR})
include_directories(${GLM_INCLUDE_DIR})
include_directories(${OPENGL_INCLUDE_DIR})

# Add all files to the configuration
file(GLOB HW4_Program_SRC
	hw4_main.cpp
    controls.cpp
    controls.h
    HCI557Common.cpp
    HCI557Common.h
	CoordSystem.cpp
	CoordSystem.h
	ImgLoader.h
	ImgLoader.cpp
	ShaderFileUtils.h
	ShaderFileUtils.cpp
)

# Create an executable
add_executable(HW4_Program ${HW4_Program_SRC})


# Add link directories
# Note required for this project
IF(WIN32)
	link_directories(${CMAKE_SOURCE_DIR}/../SDK/lib)
ELSE(WIN32)
	link_directories(${CMAKE_SOURCE_DIR}/../SDK/lib)
	link_directories(/usr/local/lib)
	link_directories(/usr/local/Cellar/glfw3/3.0.4/lib)
	link_directories(/usr/local/Cellar/glew/1.11.0/lib)
ENDIF(WIN32)


# Add libraries
target_link_libraries(HW4_Program ${GLEW_LIBRARY} ${GLFW3_LIBRARY} ${OPENGL_LIBRARIES} ${OPENGL_LIBRARIES} )
