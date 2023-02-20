window.addEventListener('scroll', function () {
	if (window.scrollY < 50) {
		window.scrollTo({ top: document.body.scrollHeight, behavior: 'smooth' });
	}
});