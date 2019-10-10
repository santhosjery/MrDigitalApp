// Sidebar
(function() {
  $('.nav_menu_icon').on('click', function() {
//    $(this).toggleClass('active');
    $('.sidebar').animate({width: 'toggle'}, 235);
  });
})();


// Nav icon actions
 $(function() {
     $('.icons_list').click(function() {
         $("div.nav-dropdown").removeClass("open");
         $(this).find('div.nav-dropdown').toggleClass('open');     
    });            
});

$(document).on('click touch', function(event) {
  if (!$(event.target).parents().addBack().is('.icons_list')) {
    $('.nav-dropdown').removeClass('open');
  }
});

$('.nav-dropdown').on('click touch', function(event) {
  event.stopPropagation();
});


 $(function() {
     $('.user').click(function() {
         $("div.nav-user-dropdown").removeClass("open");
         $(this).find('div.nav-user-dropdown').toggleClass('open');     
    });            
});

$(document).on('click touch', function(event) {
  if (!$(event.target).parents().addBack().is('.user')) {
    $('.nav-user-dropdown').removeClass('open');
  }
});

$('.nav-user-dropdown').on('click touch', function(event) {
  event.stopPropagation();
});


$('body').perfectScrollbar();
$('.dash_wrap').perfectScrollbar();


 $(function() {
     $('.sidebar .menu li').click(function() {
         $(".sub-menu").removeClass("open");
         $(this).find('.sub-menu').toggleClass('sub-menu-o');     
    });            
});


 $(function() {
     $('#logOut').click(function() {
         window.location.href = 'login.html'; 
    });            
});