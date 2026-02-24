async function loadGames() {
    const container = document.getElementById('games');
    try {
        const response = await fetch('http://localhost:5225/games');
        if (!response.ok) throw new Error('Hiba a játékok lekérésekor');
        const games = await response.json();
        if (!games.length) {
            container.textContent = 'Nincs elérhető játék.';
            return;
        }
        container.innerHTML = games.map(game => `
            <div class="game-item">
                <strong>${game.name}</strong><br>
                <span class="genre">${game.genreName || ''}</span><br>
                Ár: ${game.price} Ft
            </div>
        `).join('');
    } catch (err) {
        container.textContent = 'Hiba történt: ' + err.message;
    }
}

document.addEventListener('DOMContentLoaded', loadGames);
