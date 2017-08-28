// private access property and methods

var extraInfo = function() {

    var gender = "Male";
    var maritalStatus = "Single";
    var nationality = "Pakistani";
    var dateOfBirth = "Nov 11, 1996";
    var CNIC = "42101-2740924-9";
    var Religion = "Islam";


    var getgender = function() {
        return gender;
    };
    var getmaritalStatus = function() {
        return maritalStatus;
    };
    var getnationality = function() {
        return nationality;
    };
    var getdateOfBirth = function() {
        return dateOfBirth;
    };
    var getCNIC = function() {
        return CNIC;
    };
    var getReligion = function() {
        return Religion;
    };


    var temp = []; // create new array  
    temp.getgender = getgender;
    temp.getmaritalStatus = getmaritalStatus;
    temp.getnationality = getnationality;
    temp.getdateOfBirth = getdateOfBirth;
    temp.getCNIC = getCNIC;
    temp.getReligion = getReligion;
    return temp;

};

var educate = new extraInfo(); // constructor


// console.log(educate.getgender());

/*=====  End of Personal Information  Information  ======*/



// Constructor 
var basicInfo = function(name, age, city, cell, email) { // parameters

    var temp = [];
    temp.name = name;
    temp.age = age;
    temp.city = city;
    temp.cell = cell;
    temp.email = email;

    return temp;
};
var int = new basicInfo("Ahsan Muneer", 20, "Karachi", "03488300016", "muneerahsan@outlook.com");
// console.log(int);

/*=====  End of Basic Information  Information  ======*/
var para = {
    paragraph: "My name is Mohammad Ahsan Muneer. I am twenty years old. I am proud to be a Muslim because everyone in Islam is treated equally even if you are an Arab or non-Arab, white or black, you are treated equal. My experiences have made me. I also know how to have fun and enjoy the small things. I am a very patriotic person. I am proud to be a pakistani. I remember what my school teachers told me, how this country came into being after a million of sacrifices!. I like to play football, also playing counter strike and some strategy war games. I love the brain games. My cast is siddique. Siddiqui means The Truthful in Arabic. I'm physically strong because i know my weakness. I am logical and creative mind also thinking so well. I am a person who makes many mistakes. Every day my experience and knowledge increase, and I learn more about myself. The distance between who I am and who I want to be is separated only by my actions and words."
}
var heading = {
        header: "Software Developer | Website Developer",
        headEducation: "Education",
        skill: "Skills",
        hobby: "Passions",
        follow: "Follow me"
    }
    // var hobbies = {
    //         game: researchWork: music: movies
    //     }
    // console.log(heading.skill);
var educationSchool = {
        ssc: "BOARD OF SECONDARY EDUCATION",
        passOutYear: "2013",
        workSchool: "Matriculation (Science)",
        nameSchool: "Mehran Sublic Secondary School"
    }
    // console.log(educationSchool.ssc);
    /*=====  End of School Information  ======*/


var educationInter = {
    hsc: " BOARD OF INTERMEDIATE",
    passOutYear: "2015",
    workCollege: "Intermediate Examination (Pre-Eng)",
    nameCollege: "Jinnah College"
}

// console.log(educationInter.hsc);
/*=====  End of College Information  ======*/


var educationDegree = {
    degree: "BACHELOR OF SCIENCE",
    passOutYear: "2019 (In Progress)",
    workUniversity: "BS-Software Engineering",
    nameUniversity: "Karachi University (UBIT Department) "
}


/*=====  End of University Information  ======*/


var educationMassTraining = {
    course: "INFORMATION TECHNOLOGY",
    passOutYear: "2018 (In Progress)",
    workIT: "Website and Mobile Apllication Development",
    nameSaylani: "Mass Training Centre"
}

// skill
var skillp = {
        html: "HTML5",
        css: "CSS3",
        js: "Javascript",
        java: "Java",
        csharp: "C#",
        python: "Python ",
        sql: "SQL",
        ms: "MS-Project"
    }
    // console.log(educationMassTraining.course);
    /*=====  End of Mass Training Information  ======*/

// image
// link 
// var linked = {
//     facebook: "https://www.facebook.com/ahsan.muneer.5",
//     instagram: ""
// }


// finally call object

// var a = int.name;
// a.getElementById('name');
// console.log(a);
var introName = document.getElementById("name").innerHTML = int.name;
var introPara = document.getElementById("para").innerHTML = para.paragraph;
var header = document.getElementById("head").innerHTML = heading.header;
var education = document.getElementById("education").innerHTML = heading.headEducation;



var ssc = document.getElementById("ssc").innerHTML = educationSchool.ssc;
var sscPass = document.getElementById("pass").innerHTML = educationSchool.passOutYear;
var sscWork = document.getElementById("work").innerHTML = educationSchool.workSchool;
var sscName = document.getElementById("name1").innerHTML = educationSchool.nameSchool;


var hsc = document.getElementById("hsc").innerHTML = educationInter.hsc;
var hscPass = document.getElementById("hpass").innerHTML = educationInter.passOutYear;
var hscWork = document.getElementById("hwork").innerHTML = educationInter.workCollege;
var hscName = document.getElementById("hname1").innerHTML = educationInter.nameCollege;


var hsc = document.getElementById("degree").innerHTML = educationDegree.degree;
var hscPass = document.getElementById("dpass").innerHTML = educationDegree.passOutYear;
var hscWork = document.getElementById("dwork").innerHTML = educationDegree.workUniversity;
var hscName = document.getElementById("dname1").innerHTML = educationDegree.nameUniversity;


var hsc = document.getElementById("course").innerHTML = educationMassTraining.course;
var hscPass = document.getElementById("spass").innerHTML = educationMassTraining.passOutYear;
var hscWork = document.getElementById("swork").innerHTML = educationMassTraining.workIT;
var hscName = document.getElementById("sname1").innerHTML = educationMassTraining.nameSaylani;


var hscName = document.getElementById("Skills").innerHTML = heading.skill;


// list

var ul1 = document.getElementById("ul1").innerHTML = skillp.html;
var ul2 = document.getElementById("ul2").innerHTML = skillp.css;
var ul3 = document.getElementById("ul3").innerHTML = skillp.js;
var ul4 = document.getElementById("ul4").innerHTML = skillp.java;
var ul5 = document.getElementById("ul5").innerHTML = skillp.csharp;
var ul6 = document.getElementById("ul6").innerHTML = skillp.python;
var ul7 = document.getElementById("ul7").innerHTML = skillp.sql;
var ul8 = document.getElementById("ul8").innerHTML = skillp.ms;

/// images ///

// var searchPic;

var hobby = document.getElementById("hobbyheading").innerHTML = heading.hobby;
var follow = document.getElementById("followme").innerHTML = heading.follow;


// personal info
// extraInfo
// basicinfo

// var gender = "Male";
// var maritalStatus = "Single";
// var nationality = "Pakistani";
// var dateOfBirth = "Nov 11, 1996";
// var CNIC = "42101-2740924-9";
// var Religion = "Islam";
// var age = 20;
// var cell = 0348
// var email = ahasn


// var gend = document.getElementById("").innerHTML = extraInfo.gender;
// var maritalStatus = document.getElementById("").innerHTML = extraInfo.maritalStatus;
// var nationality = document.getElementById("").innerHTML = extraInfo.nationality;
// var dateOfBirth = document.getElementById("").innerHTML = extraInfo.dateOfBirth;
// var CNIC = document.getElementById("").innerHTML = extraInfo.CNIC;
// var Religiond = document.getElementById("").innerHTML = extraInfo.Religion;

// var age = document.getElementById("").innerHTML = basicInfo.age;
// var cell = document.getElementById("").innerHTML = basicInfo.cell;
// var email = document.getElementById("").innerHTML = basicInfo.email;