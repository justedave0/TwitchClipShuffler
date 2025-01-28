# TwitchClipShuffler

TwitchClipShuffler is a simple Streamer.bot plugin that automatically shuffles through your Twitch clips and displays them via a browser source in OBS or Streamlabs OBS. Perfect for showing off your best clips during a "Pause" scene or whenever you step away from your stream!

### Key Features:
- Automatically shuffles through your Twitch clips.
- Customizable settings to suit your needs.
- Integrates seamlessly with Streamer.bot and OBS/Streamlabs OBS.
- Highlights your **Featured** clips (optional) for maximum impact.

---

## Example Use Case

You switch to a "Pause" scene in OBS and want to entertain your viewers by displaying some of your best Twitch clips. With **TwitchClipShuffler**, you can automate this process in just a few steps.

---

## Setup Instructions

### 1. Create a Browser Source in OBS
- Add a **new browser source** to your scene in OBS or Streamlabs OBS.  
- Set the resolution to **1920x1080**. You can resize it manually later if needed.

![Browser Source Example](https://github.com/user-attachments/assets/54120888-38d8-4d5a-b2fb-1bf1d3826302)

---

### 2. Import the Plugin into Streamer.bot
- Download the action code from the repository:  
  [TwitchClipShuffler Action Code](https://github.com/justedave0/TwitchClipShuffler/blob/main/importToStreamer.Bot)  
- Import the code into your **Streamer.bot** instance.

![Streamer.bot Import Example](https://github.com/user-attachments/assets/f422e3a5-76a5-4dfa-9a20-2f024fa7e9db)

---

### 3. Configure the Triggers
- In Streamer.bot, navigate to the **Triggers** list.  
- Specify the **exact name** of the scene in OBS where you want TwitchClipShuffler to activate.  
  For example: If you want this to run in your "Pause" scene, set the scene name accordingly.  
- The plugin will automatically shuffle your clips when you switch to the specified scene.

![Scene Trigger Setup](https://github.com/user-attachments/assets/9b0474b2-52e3-4f31-b9b8-573f59b1decc)

---

### 4. Adjust the Plugin Settings
- Open the action settings in Streamer.bot.  
- Configure the following arguments to match your setup:

1. **Mandatory Arguments**:
   - **Scene Name**: The name of your scene in OBS (e.g., "Pause").
   - **Source Name**: The name of your browser source in OBS.

2. **Optional Arguments**:
   - **`nbClips`**: Number of clips to shuffle through (default: newest clips).
   - **`isFeatured`**: Enable this to shuffle only **Featured** clips (great for showing your best moments).
   - **`isRandom`**: Shuffle clips randomly or start with the most viewed ones.

![Action Settings Example](https://github.com/user-attachments/assets/8b8757b7-2a45-4840-8491-3ad8bb13a3aa)

---

## Notes
- Once set up, the plugin will continue working until you rename the scene or source. If you make changes, be sure to update the settings in Streamer.bot.
- Featured clips are highly recommended for quality control since only you (or your editors) can mark a clip as Featured.

---

## Feedback and Support
If you encounter any issues or have suggestions, feel free to open an issue on the repository. Contributions are welcome!
