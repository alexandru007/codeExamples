/*

The program asks for 3 floating points from a user
displays the sum, average, product, smallest, largest 
range and median of these numbers as strings on the applet.

*/

import java.awt.Graphics;       // program uses class Graphics
import javax.swing.JApplet;     // program uses class JApplet
import javax.swing.JOptionPane; // program uses class JOptionPane

public class AdditionApplet extends JApplet{
    
    // variables 
    private double first, second, third;
	private double sum, product, largest, smallest, median, range, quotient, average;

    // method to find the largest number
    private double largestNum(double a, double b, double c){
        return Math.max(Math.max(a, b), c);
    }

    // method to find the smallest number  
    private double smallestNum(double a, double b, double c){
       return Math.min(Math.min(a, b), c);
    }

    // method to find the median number
    private double medianNum(double a, double b, double c){
        double sum = a + b + c;
        double max = largestNum(a, b, c);
        double min = smallestNum(a, b, c);
        return (sum - (max + min));
    }

	// initialize applet by obtaining values from user
    public void init(){
        
        // strings entered by user
        String firstNum;  
        String secondNum; 
        String thirdNum; 

        // obtain first number from user
        firstNum = JOptionPane.showInputDialog(
                "Enter first floating-point value" );

        // obtain second number from user
        secondNum = JOptionPane.showInputDialog(
                "Enter second floating-point value" );

        // obtain third number from user
        thirdNum = JOptionPane.showInputDialog(
                "Enter third floating-point value" );

        // convert numbers from type String to type double
        first = Double.parseDouble( firstNum ); 
        second = Double.parseDouble( secondNum );
        third = Double.parseDouble( thirdNum );

        // calculating the sum, average, product, 
		// smallest, largest, range, median
        sum = (first + second + third);
        product = (first * second * third);
        largest = largestNum(first, second, third);
        smallest = smallestNum(first, second, third);
        median = medianNum(first, second, third);
        range = largest - smallest;
        average = sum/3;
        quotient = largest/smallest;
		
    } // end method init

    // draw results in a rectangle on applet’s background
    public void paint( Graphics g ){
        // call superclass version of method paint
        super.paint( g ); 

        // draw rectangle starting from (15, 10) box size 300 x 240
        // pixels wide and 20 pixels tall
        g.drawRect( 15, 10, 350, 240 );
        
        // draw the strings in separate boxes
        // positioning each one down by 25 pixels
        g.drawString(String.format("The numbers entered are %.2f, %.2f, %.2f", first, second, third), 25,25);
        g.drawString(String.format("The sum is %.2f", sum), 25, 50 );
        g.drawString(String.format("The product is %.2f", product), 25, 75 );
        g.drawString(String.format("The largest is %.2f", largest), 25, 100 );
        g.drawString(String.format("The smallest is %.2f", smallest), 25, 125 );
        g.drawString(String.format("The average is %.2f", average), 25, 150 );
        g.drawString(String.format("The median is %.2f", median), 25, 175 );
        g.drawString(String.format("The ranges is %.2f", range), 25, 200 );
        g.drawString(String.format("The quotient of the largest divided by smallest is %.2f", quotient), 25, 225 );
		
   } // end method paint
} // end class AdditionApplet
