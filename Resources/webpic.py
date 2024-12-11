import cv2
import os

def capture_and_save_image():
    try:
        # Define the file path
        appdata_dir = os.getenv('APPDATA')
        if not appdata_dir:
            print("APPDATA environment variable not found.")
            return

        file_path = os.path.join(appdata_dir, 'webimg.png')
        
        # Remove the old file if it exists
        if os.path.exists(file_path):
            os.remove(file_path)
        
        # Initialize the webcam
        cap = cv2.VideoCapture(0)
        if not cap.isOpened():
            print("")
            return
        
        # Capture a frame
        ret, frame = cap.read()
        if not ret:
            print("")
            cap.release()
            return
        
        # Save the captured frame to file
        cv2.imwrite(file_path, frame)
        
        # Release the webcam
        cap.release()

    except Exception as e:
        print(f"An error occurred: {e}")

if __name__ == "__main__":
    capture_and_save_image()
