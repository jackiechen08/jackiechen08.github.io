function openNav() {	//side nav opening
    document.getElementById("side").style.width = "310px";
    $(".side-title").css("font-size", "23px");
    $(".side-content").css("font-size", "18px");
}

function closeNav() {	//side nav closing
	document.getElementById("side").style.width = "0";
	$(".side-title").css("font-size", "0");
    $(".side-content").css("font-size", "0");
	close_opened();
}
var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
       slides[i].style.display = "none";  
    }
    slideIndex++;
    if (slideIndex> slides.length) {slideIndex = 1}    
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";  
    dots[slideIndex-1].className += " active";
    setTimeout(showSlides, 2000); // Change image every 2 seconds
}

var acc = document.getElementsByClassName("accordion");		//accordion->下拉選單的<a>
var i;
for (i = 0; i < acc.length; i++) {	//accordion註冊event
    acc[i].onclick = function(){
        var flag = 0;	//有.active
        if(!$(this).hasClass('active'))
        	if($(this).hasClass('item-2'))
        		flag = 2;	//has 2 items
        	else
        		flag = 3;	//has 3 items
        close_opened();
        if(flag != 0 ){		//open the selected list
        	$(this).addClass('active');
        	if(flag == 2){
        		$(this).next().addClass('show');
        	}else{
        		$(this).next().addClass('show3');
        	}
        }
    }
}
function close_opened(){
	$('.accordion').each(function(index){	//close the opened list
		if($(this).hasClass('active'))
			$(this).removeClass('active');
			if($(this).hasClass('item-2')){
				$(this).next().removeClass('show');
				$(this).children('i').removeClass('fa-rotate-180');
			}else{
				$(this).next().removeClass('show3');
				$(this).children('i').removeClass('fa-rotate-180');
			}
	});
}