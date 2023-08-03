# Strategy Design Pattern
Use : To provide changing behavior of a class without modifying it

Example Explained:

1. Started with a abstract class called TravelStrategy which have a variable called KilometerCost and one abstract method Drive.
2. Second class I created is TravelPlanner class, in this class created a method called SetTravelStrategy(), and this method takes object as its input, also this class has another method which is known as Drive()
3. Other 3 classes Bus, Car and Plane are inharited from TravelStrategy class. All these classes have a default constructor which define the KilometerCost and one override drive method.
4. In main method, first I created object of a TravelPlanner class, using that object we call two methods, SetTravelStrategy() in which we call the constructor of the Plane class, Drive() in which we pass the number of kilometers.

Flow of the program:

1. In Main Method, first step will be the object creation of TravelPlanner class.
2. Using that object SetTravelStrategy() method is called with the constructor of Plane() class and that constructor is defining the KilometerCost.
3. SetTravelStrategy() method is defining the _travelStrategy in our example it is Plane.
4. travelPlanner.Drive(999), this line calls the Drive method of TravelPlanner Class.
5. In Drive method of TravelPlanner class another Drive() method is called using _travelStrategy variable which we set in step 3.
