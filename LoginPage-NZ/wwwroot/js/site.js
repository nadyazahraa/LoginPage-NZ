document.getElementById('loginForm').addEventListener('submit', function (e) {
    e.preventDefault(); 
   
    var username = document.getElementById('username').value;
    var password = document.getElementById('password').value;

    if (username === 'admin' && password === 'password') {
        alert('Login berhasil!');
        window.location.href = 'dashboard.html';
    } else {
        alert('Username atau password salah!');
    }
});
