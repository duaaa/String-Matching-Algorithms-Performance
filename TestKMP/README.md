<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <h1>String Matching Project</h1>
</head>
<body>
<h3>Description</h3>
<p>This project is related to the String Matching with KMP, BM and Navie algorithm.</p>
<p><h3> Knuth Morris Pratt (KMP)</h3> is an algorithm, which checks the characters from left to right.
When a pattern has a sub-pattern appears more than one in the sub-pattern, 
it uses that property to improve the
time complexity, also for in the worst case. The processing time of KMP is O(m) and 
its time complexity of KMP is O(n).</p>
<p> <h3>Naïve pattern searching</h3>is the simplest method among other pattern searching algorithms. 
It checks for all character of the main string to the pattern.
This algorithm is helpful for smaller texts. It does not need any pre-processing phases.
The time complexity is O(m*n) where m is the size of pattern and n is the size 
of the main string</p>
<p><h3>
Boyer–Moore 
</h3>
 string-search algorithm is an efficient method 
 that is the standard benchmark for practical string-search literature. 
 It was developed by Robert S. Boyer and J Strother Moore in 1977.
 This algorithm runs faster as the pattern length increases.
 Running time of this algorithm is O ( n m )
</p>
<p>Our project contains three models in the Utils folder BM.cs , KMP.cs , Naive.cs. 
These classes contains main algorithm in it. 
We also have a dataset in the Models/Dataset folder in which we contain the datasets 
which we are using in our algorithm. We get our dataset from the https://www.kaggle.com/datasets 
. Futher, we also have a controller as a main function to call our the models according 
to the user's choice. </p>
<p> In the searchInfo.cs class we have three classes <b>Performance</b> in which we 
have parameters of no.ofstatementexecuted as we are doing in list and the parameter to check the memory consumption.
<b>Search Info</b> is also a class which contains the parameters that get the use's choice for the algorithm that is to be executed.
<b>Statement</b> class which contain a parameter statementnumber which counts the no.of times a statement is executed.

</p>
<h3>Installation</h3>
<p>Before executing this project, you have to change the path of getting the dataset's file according to your PC.</p>
<h3>Support</h3>
<p>If you need any help, you can contact us through our emails.
seharejaz1997@gmail.com OR 
mduaaas@gmail.com
</p>
<h3>Contributing</h3>
<p>As this is a private project no one from the outside is allowed to contribute in it.</p>
<h3>Authors</h3>
<p>Dua and Sahar made this project.</p>
</body>
</html>
