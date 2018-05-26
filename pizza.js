function calcPrice(){
	var orderSelectionHTML = "<ul class='list-totals'>";
			var priceSize = document.querySelector('[name="pizzaSize"]:checked').value;
			var itemize = new Array();
			if(priceSize == 6.00){
					nameSize = "Personal";
			}
			else if(priceSize == 10.00 ){
					nameSize = "Medium";
			}
			else if(priceSize == 14.00){
					nameSize = "Large";
			}
			else if(priceSize == 16.00){
					nameSize = "Extra Large";
			}
			else{nameSize = "";}
				itemize.push("My cost is:");
				itemize.push(nameSize+": "+priceSize);
				
			for(var i in itemize){
				orderSelectionHTML += "<li>";
				orderSelectionHTML += itemize[i];				
				orderSelectionHTML += "</li>";
			}
			
			orderSelectionHTML += "</ul>";
			
			console.log(orderSelectionHTML);
			document.getElementById("total").innerHTML =orderSelectionHTML;
		
			
			//	Meat
			var meatCheck = document.querySelectorAll('input[class="meat"]').length; 
			var checks = document.getElementsByClassName('meat');
			var stringMeat = ""; 
			var priceMeat = 0;
			var meatCount = 0; 
			for(var i=0; i < meatCheck; i++) {
				if (checks[i].checked === true) {
					stringMeat += checks[i].name + "<br>"; 
					priceMeat += parseFloat(checks[i].value);
					if (meatCount === 0) {
						priceMeat = 0;
						meatCount = meatCount + 1;
					}
				}
			}

			

			/*console.log(nameSize+": "+priceSize);
			console.log(itemize);
			
			
			// Cheese
			var cheese = document.querySelector('input[class="cheese"]:checked').value;
			var nameCheese = document.querySelector('input[class="cheese"]:checked').id;
			var priceCheese = parseFloat(cheese);
			document.getElementById("pizzaCheese").innerHTML = '<li>' + nameCheese + '</li>';
			document.getElementById("cheesePrice").innerHTML = '<li> Subtotal: $' + priceCheese + '</li>';
			var result = priceSize+priceCheese; 
			
			// Crust
			var crust = document.querySelector('input[class="crust"]:checked').value;
			var nameCrust = document.querySelector('input[class="crust"]:checked').id;
			var priceCrust = parseFloat(crust);
			document.getElementById("pizzaCrust").innerHTML = '<li>' + nameCrust + '</li>';
			document.getElementById("crustPrice").innerHTML = '<li> Subtotal: $' + priceCrust + '</li>';
			var result =priceSize+priceCheese+priceCrust; 
			
			// Sauce
			var sauce = document.querySelector('input[class="sauce"]:checked').value;
			var nameSauce = document.querySelector('input[class="sauce"]:checked').id;
			var priceSauce = parseFloat(sauce);
			document.getElementById("pizzaSauce").innerHTML = '<li>' + nameSauce + '</li>';
			document.getElementById("sizePrice").innerHTML = '<li> Subtotal: $' + priceSauce + '</li>';
			var result = priceSize+priceCheese+priceCrust+priceSauce; 
			
			//	Veggies
			var veggiesCheck = document.querySelectorAll('input[class="veggies"]').length;
			var checks = document.getElementsByClassName('veggies');
			var stringVeggies = ""; 
			var priceVeggies = 0;
			var veggiesCount = 0;
			for(var i=0; i < veggiesCheck; i++) {
				if (checks[i].checked === true) { 
					stringVeggies += checks[i].name + "<br>"; 
					priceVeggies += parseFloat(checks[i].value);
					if (veggiesCount === 0) {
						priceVeggies = 0;
						veggiesCount = veggiesCount + 1;
					}
				}
			}
			var result = priceSize+priceCheese+priceCrust+priceSauce+priceVeggies; 
	document.getElementById("total").innerHTML = "Total price: $" + result;
*/
	}