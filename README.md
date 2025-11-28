<div align="center">

<h1>🚀 SharpType</h1>
<h3>The Modern, High-Performance Typing Trainer</h3>

<p>
A lightweight, dark-themed typing engine built from scratch in C# Windows Forms.
<br />
<b>No External Libraries. Pure Logic.</b>
</p>

<!-- Badges -->

<p>
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Language-C%2523-239120%3Fstyle%3Dfor-the-badge%26logo%3Dc-sharp%26logoColor%3Dwhite" alt="C#">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Framework-.NET-512BD4%3Fstyle%3Dfor-the-badge%26logo%3Ddotnet%26logoColor%3Dwhite" alt=".NET">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Platform-Windows%2520Forms-0078D4%3Fstyle%3Dfor-the-badge%26logo%3Dwindows%26logoColor%3Dwhite" alt="WinForms">
<img src="https://www.google.com/search?q=https://img.shields.io/badge/Status-Completed-success%3Fstyle%3Dfor-the-badge" alt="Status">
</p>

<br />

<!-- SCREENSHOT PLACEHOLDER -->

<!-- 📸 Take a screenshot of your app, save it as 'screenshot.png', and it will appear here -->

<img src="SharpType.png" alt="SharpType Interface" width="800" style="border-radius: 10px; box-shadow: 0px 4px 20px rgba(0,0,0,0.5);">

</div>

<br />

📖 About The Project

SharpType is not just another text box. It is a fully custom-engineered typing environment designed to improve muscle memory and typing speed.

Unlike standard forms that rely on basic input, SharpType intercepts the Windows Message Loop to provide a seamless, game-like experience. It features a custom rendering engine that handles real-time validation, cursor tracking, and mechanical sound feedback with zero latency.

✨ Key Features

🎮 Immersive Experience

Visual Keyboard: On-screen keys glow dynamically (KeyDown/KeyUp) to reinforce muscle memory without looking at your hands.

Mechanical Audio: Crisp, low-latency sound effects on every keystroke using System.Media.

Smart Cursor: An orange highlight guide that leads your eyes to the next target character.


⚡ Performance & Modes

Sprint Modes: Test your speed in 15s, 30s, or 60s bursts.

3 Difficulty Tiers: Curated texts ranging from simple village stories to complex scientific articles.

Instant Feedback: - <span style="color:#90EE90"><b>Green</b></span> for correct hits.

<span style="color:#FF6B6B"><b>Red</b></span> for mistakes (Stop-on-Error logic).


📊 Real-Time Analytics

WPM Calculator: Precise "Words Per Minute" algorithm accounting for standard 5-character word lengths.

Accuracy Engine: Tracks every error relative to total keystrokes for a fair percentage score.

🛠️ Under the Hood (Technical Engineering)

This project was built to demonstrate Data Structures and Clean Architecture over simple drag-and-drop coding.


1. Dictionary Mapping (O(1) Performance)

Instead of writing 26+ if-else statements to check which key was pressed, I implemented a Dictionary to map physical keys to visual controls instantly.

// The Engine Core: Mapping Hardware Keys to UI Buttons
Dictionary<Keys, Button> keyMap = new Dictionary<Keys, Button>();

// O(1) Lookup Speed - No iterating through lists
if (keyMap.ContainsKey(e.KeyCode)) 
{
    keyMap[e.KeyCode].BackColor = Color.Turquoise; // Instant Glow
}



2. Advanced Event Handling

The app intercepts the Operating System's input stream to separate "Game Logic" from "Text Input".

KeyDown: Triggers the visual glow and sound (Physically reactive).

KeyPress: Handles the game logic, scoring, and text validation (Logically reactive).

e.Handled = true: Prevents the OS from printing text to the screen, allowing the custom engine to render colored text manually.

3. Modular Architecture

The codebase follows a clean separation of concerns:

ResetGame(): Handles state management.

CalculateResults(): Pure logic functions for math.

ResetVisuals(): UI-specific cleanup.


<div align="center">
<i>"Code is like humor. When you have to explain it, it’s bad." – Cory House</i>
</div>
