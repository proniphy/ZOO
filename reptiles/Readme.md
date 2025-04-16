In my branch I have implemented abstract class reptile, as well as a couple children classes. I also have some interfaces implemented.

16/04:  Made changes to Reptile class to accomodate the assignment: added more methods, some abstract and some virtual, as well as a virtual property. 
        Also fixed the check for legs to be in the property. 
        Added class Lizard, which inherits Reptile. There I changed some methods, and added more methods as well. 
        Reworked Chameleon class to be inheriting Lizard. 
        Added a class PantherChameleon, which can be initialized. 

        I am getting an error "Inconsistent accessibility: base class 'Animal' is less accessible than class 'Reptile'" because the Animal class is internal, while my reptile class is public. However, the Reptile class needs to be public for the assignment's first point. Please advise whether I need to make my classes internal for the code to compile.