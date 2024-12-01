INSERT INTO Reminders
    (Title, ReminderDateTime, Category, Priority, Status, Recurrence, Notes, CreatedAt, UpdatedAt, NotificationMethod) 
VALUES
    ('Morning Medication', '2024-12-01 08:00:00', 'Medication', 1, 0, 'Daily', 'Take blood pressure and diabetes medication.', GETDATE(), GETDATE(), 'Popup'),
    ('Follow-up Appointment with Cardiologist', '2024-12-02 10:30:00', 'Appointments', 1, 0, 'None', 'Discuss test results with Dr. Brown.', GETDATE(), GETDATE(), 'Popup'),
    ('Lunch Reminder', '2024-12-03 12:30:00', 'Meals & Liquids', 2, 0, 'Daily', 'Prepare a balanced meal with protein and greens.', GETDATE(), GETDATE(), 'Popup'),
    ('Hydration Alert', '2024-12-03 15:00:00', 'Meals & Liquids', 3, 0, 'Hourly', 'Drink a glass of water to stay hydrated.', GETDATE(), GETDATE(), 'Popup'),
    ('Evening Walk', '2024-12-03 18:00:00', 'Exercise', 2, 0, 'Daily', 'Take a 30-minute walk around the park.', GETDATE(), GETDATE(), 'Popup'),
    ('Medication Refill Reminder', '2024-12-05 09:00:00', 'Medication', 1, 0, 'None', 'Order refill for prescribed medication.', GETDATE(), GETDATE(), 'Popup'),
    ('Physical Therapy Session', '2024-12-06 11:00:00', 'Appointments', 2, 0, 'None', 'Attend therapy for back pain recovery.', GETDATE(), GETDATE(), 'Popup'),
    ('Dinner Reminder', '2024-12-06 19:00:00', 'Meals & Liquids', 2, 0, 'Daily', 'Prepare a light dinner with a focus on fiber.', GETDATE(), GETDATE(), 'Popup'),
    ('Morning Yoga', '2024-12-07 06:00:00', 'Exercise', 1, 0, 'Daily', 'Practice yoga to improve flexibility.', GETDATE(), GETDATE(), 'Popup'),
    ('Doctor Check-Up for Annual Exam', '2024-12-10 09:00:00', 'Appointments', 1, 0, 'Yearly', 'Full body check-up with Dr. Adams.', GETDATE(), GETDATE(), 'Popup');
