// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    // You can toggle testMode to true to bypass the localStorage check during testing
    var testMode = true;  // Set this to true to test splash screen every time

    if (testMode || !localStorage.getItem('splashScreenShown')) {
        // Show splash screen and set the localStorage flag
        setTimeout(() => {
            document.body.classList.add('loaded'); // Show main content
            document.getElementById('splash-screen').style.display = 'none'; // Hide splash screen
            localStorage.setItem('splashScreenShown', 'true'); // Mark splash screen as shown
        }, 5000); // 3-second splash screen duration
    } else {
        // Directly show the main content if the splash has already been shown
        document.getElementById('splash-screen').style.display = 'none';
        document.body.classList.add('loaded'); // Show main content immediately
    }
});



// JavaScript function to toggle the door icon
function toggleDoorState(checkbox) {
    const icon = document.querySelector('.door-icon');
    if (checkbox.checked) {
        icon.classList.remove('fa-door-open');
        icon.classList.add('fa-door-closed');
    } else {
        icon.classList.remove('fa-door-closed');
        icon.classList.add('fa-door-open');
    }
}

// Load saved states from Local Storage
document.addEventListener("DOMContentLoaded", function () {
    // Bedroom Lights
    const bedroomLights = document.getElementById('bedroomLights');
    const savedBedroomLights = localStorage.getItem('bedroomLights');
    if (savedBedroomLights === 'true') {
        bedroomLights.checked = true;
    }

    // TV
    const tv = document.getElementById('tv');
    const savedTv = localStorage.getItem('tv');
    if (savedTv === 'true') {
        tv.checked = true;
    }

    // Door Lock
    const doorToggle = document.getElementById("doorToggle");
    if (!doorToggle) {
        console.error("Element with ID 'doorToggle' is missing");
    }
    const doorIcon = document.getElementById('doorIcon');
    const savedDoorState = localStorage.getItem('doorLocked');
    if (savedDoorState === 'true') {
        doorToggle.checked = true;
        doorIcon.classList.replace('fa-door-open', 'fa-door-closed');
    } else {
        doorToggle.checked = false;
        doorIcon.classList.replace('fa-door-closed', 'fa-door-open');
    }

    // Fans
    const fans = document.getElementById('fans');
    const savedFans = localStorage.getItem('fans');
    if (savedFans === 'true') {
        fans.checked = true;
    }
});

// Save state to Local Storage when a toggle is changed
document.getElementById('bedroomLights').addEventListener('change', function () {
    localStorage.setItem('bedroomLights', this.checked);
});

document.getElementById('tv').addEventListener('change', function () {
    localStorage.setItem('tv', this.checked);
});

document.getElementById('doorToggle').addEventListener('change', function () {
    localStorage.setItem('doorLocked', this.checked);

    // Update door icon dynamically based on the state
    const doorIcon = document.getElementById('doorIcon');
    if (this.checked) {
        doorIcon.classList.replace('fa-door-open', 'fa-door-closed');
    } else {
        doorIcon.classList.replace('fa-door-closed', 'fa-door-open');
    }
});

document.getElementById('fans').addEventListener('change', function () {
    localStorage.setItem('fans', this.checked);
});


// Check if annyang is available
if (annyang) {
    // Define voice commands and actions for device control
    const commands = {
        'turn on bedroom lights': () => {
            document.getElementById('bedroomLights').checked = true;
            localStorage.setItem('bedroomLights', true);
            alert('Bedroom lights turned ON!');
        },
        'turn off bedroom lights': () => {
            document.getElementById('bedroomLights').checked = false;
            localStorage.setItem('bedroomLights', false);
            alert('Bedroom lights turned OFF!');
        },
        'turn on TV': () => {
            document.getElementById('tv').checked = true;
            localStorage.setItem('tv', true);
            alert('TV turned ON!');
        },
        'turn off TV': () => {
            document.getElementById('tv').checked = false;
            localStorage.setItem('tv', false);
            alert('TV turned OFF!');
        },
        'lock door': () => {
            const doorToggle = document.getElementById('doorToggle');
            doorToggle.checked = true;
            localStorage.setItem('doorLocked', true);
            const doorIcon = document.getElementById('doorIcon');
            doorIcon.classList.replace('fa-door-open', 'fa-door-closed');
            alert('Door locked!');
        },
        'unlock door': () => {
            const doorToggle = document.getElementById('doorToggle');
            doorToggle.checked = false;
            localStorage.setItem('doorLocked', false);
            const doorIcon = document.getElementById('doorIcon');
            doorIcon.classList.replace('fa-door-closed', 'fa-door-open');
            alert('Door unlocked!');
        },
        'turn on fans': () => {
            document.getElementById('fans').checked = true;
            localStorage.setItem('fans', true);
            alert('Fans turned ON!');
        },
        'turn off fans': () => {
            document.getElementById('fans').checked = false;
            localStorage.setItem('fans', false);
            alert('Fans turned OFF!');
        }
    };

    // Add commands to annyang
    annyang.addCommands(commands);

    // Button to start voice control
    const startButton = document.getElementById('startVoiceControl');
    startButton.addEventListener('click', () => {
        annyang.start();
        alert('Voice control activated!');
    });

    // Optional: Debugging
    annyang.addCallback('result', function (phrases) {
        console.log('Recognized phrases:', phrases);
    });
} else {
    alert('Voice recognition is not supported in this browser.');
}