<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <h1>String Matching Project</h1>
</head>
<body>
<h3>Description</h3>
<p>A simple solution for the Perfomance Analysis of String Matching Algorithms (KMP, BM and Navie algorithm).</p>
<p>This code repository makes the task of searching for a genome sequence easier with a built in .Net MVC user interface.
    Intially contains in built Severe Acute Respiratory Syndrome (SARS) dataset which can be replaced within the dataset class. 
    </p>
    <p>Basically gives you a performance statistics based on the following parameters:
        <br/>1. Running Time <br/>
        2. Indexes Found <br/>
        3. Number of lines executed<br/>
        4. Space / Memory Consumed </p>
        
   
<p><h3> Knuth Morris Pratt (KMP)</h3> is an algorithm, which checks the characters from left to right.
When a pattern has a sub-pattern appears more than once in the sub-pattern, 
it uses that property to improve the time complexity, as well as in the worst case scenario. The processing time of KMP is O(m) and 
its time complexity of KMP is O(n).</p>
<p> <h3>Naïve pattern searching</h3> is the simplest method among other pattern searching algorithms. 
It checks for all character of the main string to the pattern.
This algorithm is helpful for smaller texts. It does not need any pre-processing phases.
The time complexity is O(m*n) where m is the size of pattern and n is the size 
of the main string</p>
<p><h3>
Boyer–Moore 
</h3>
  string-search algorithm is an efficient method  that is the standard benchmark for practical string-search literature. 
 It was developed by Robert S. Boyer and J Strother Moore in 1977.
 This algorithm runs faster as the pattern length increases.
 Running time of this algorithm is O ( n m )
</p>
<p>Our project contains three models in the Utils folder BM.cs , KMP.cs , Naive.cs. 
These files contains classes responsible for the actual algorithm logic. 
    
<h3>Dataset</h3>
Our dataset class is responsible for loading the dataset from csv file. This file contains quarter of the Severe Acute Respiratory Syndrome (SARS) dataset obtained from https://www.kaggle.com/spowers/sarssequencedata?select=sars_combined_sequences.csv

Futher, Our home controller is set as the startup call to our the search models. Here user is provided access to a search interface with options for algorithms to choose. The search is carried out according to this option.</p>
<p> In the searchInfo.cs class we have three classes <b>Performance</b> in which we 
have parameters of no of statements executed as we are doing in list and the parameter to check the memory consumption.
<b>Search Info</b> is also a class which contains the parameters that get the use's choice for the algorithm that is to be executed.
<b>Statement</b> class which contain a parameter statementnumber which counts the no of times a statement is executed.

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
<p>Made by Dua and Sahar.</p>
</body>
</html>
