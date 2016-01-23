(function () {
	document.addEventListener('DOMContentLoaded', function() {
		var $menuNews = $('#jsMenuNews'),
			$menuContact = $('#jsMenuContact');

		$menuNews.on('click', function () {
			$(this).next().slideToggle('fast');
			$(this).toggleClass('active');
		});

		$menuContact.on('click', function () {
			$(this).next().slideToggle('fast');
			$(this).toggleClass('active');
		});
	});
})();