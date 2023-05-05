# Project 02:  Paint - Windows Programming - 20KTPM- HCMUS

This app offers a user-friendly interface like Painting application on Windows that allows users to easily create and edit images using various brush types, color and more
|Fullname | MSSV |
|--|--|
|Nguyễn Thanh Thảo  |19127552|


# Instructions to download the file and run it for the first time

**Step 1**. Clean solution, after that, build solution (or rebuild)

**Step 2**. Go to the folder **\Project02-Paint\LineAbility\bin\Debug\net6.0-windows** -> Copy file **LineAbility.dll** -> Paste to folder **\Project02-Paint\Project02-Paint\bin\Debug\net6.0-windows**

**Step 3**. Do the same with **RectangeAbility**, **EllipseAbility**, **ImageAbility** folder

## Instructions on how to extend Drawing Type:

**Step 1**.  Create a project typed **"WPF Class Library"** in your project, name two files according to the format **< Shape >Ability.cs** và **< Shape >Drawer.cs**. You must refer to the format of code other WPF class library (like **RectangeAbility**, **EllipseAbility**,...)  and main interface **MyContract** to configure it properly.

**Step 2**.  At Dependencies -> choose Add Project Preferences-> choose MyContract

**Step 3**.  Every time you create new code or change related code of the drawing, please rebuild the WPF Class Library project (of this shape) and copy the .dll file into Project02-Paint (just like running it for the first time).

# Describe all features have been completed

All basic features have been completed. In addition,  I have added some improved features. I will explain in more detail below.

## Technical details

- Design patterns: Singleton, Factory, Abstract factory, prototype, command pattern

- Plugin architecture

- Delegate & event

## Basic graphic object (completed 100%)

- Line: controlled by two points, the starting point, and the endpoint.

- Rectangle: controlled by two points, the left top point, and the right bottom point.

- Ellipse: controlled by two points, the left top point, and the right bottom point.

## Core requirements (completed 100%)
1. Dynamically load all graphic objects that can be drawn from external DLL files

2. The user can choose which object to draw

3. The user can see the preview of the object they want to draw

4. The user can finish the drawing preview and their change becomes permanent with previously drawn objects

5. The list of drawn objects can be saved and loaded again for continuing later in self-defined binary format.

6. Save and load all drawn objects as an image in bmp/png/jpg format (rasterization).

## Improvements

1. Allow the user to change the color, pen width, stroke type (dash, dot, dash dot dot...
2. Adding image to the canvas
3. Zooming
4. Cut / Copy / Paste
5. Undo, Redo
6. Fill color by boundaries
7. Using command pattern for build main feature of the application
8. If  "New File" button to quickly start over, the application will of course ask the user for confirmation if any new changes is detected.
9. Used Fluent.Ribbon for user interface.

## UML Diagram of application
 ![Untitled Diagram drawio (1)](https://user-images.githubusercontent.com/63916162/235377604-a09d5c06-dc72-484c-be11-2ee873e8a00f.png)


## Self-assessment score
**14 điểm** 

## Link drive video demo

https://drive.google.com/file/d/1MBvbeOsH52OSvTHrN7KClim9QqNtMf4V/view?usp=sharing

## Link github
https://github.com/windows-programing-hcmus/Project02-Paint.git
