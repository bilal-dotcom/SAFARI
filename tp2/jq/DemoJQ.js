$(document).ready(function () {


	$(".choix").on({

		mouseenter: function () {
			$(this).css('opacity', '2'),
				$(this).animate({
					height: '400px',
					width: '400px'
				});;
		},

		mouseleave: function () {
			$(this).css('opacity', '0.5')
			$(this).animate({
				height: '160px',
				width: '160px'
			});;
		}
	});

	var bouton = document.getElementById('save');

	$("#save").click(function () {

		console.log("okk");
		var nom = document.getElementById('nom');
		var email = document.getElementById('email');
		var phone = document.getElementById('phone');
		var msg = document.getElementById('msg');


		var em = new Message(nom.value, email.value, phone.value, msg.value);

	

		if (!em.validateTel()) {
			phone.style.borderColor = "red";

		}
		else {
			phone.style.borderColor = "black";
		}


	});


	var em;

	 

	class Message{

		constructor(nom,email,phone,message) {
			this.nom = nom;
			this.email = email;
			this.phone = phone;
			this.message = message;
		}

	}

	function validateTel() {

		var telregex = /^(\(\d{3}\)) ?\d{3}-\d{4}/;

		if (telregex.test(this.phone)) {
			return true;
		}
		else {
			return false;
		}

	};

	function validateEmail() {

		var emailRegEx = /[a-zA-Z0-9]+(\.|_|-)?[a-zA-Z0-9]+@teccart\.qc\.ca/;
		if (emailRegEx.test(this.email)) {
			return true;  //code
		}
		else {
			return false;
		}
	}


});
