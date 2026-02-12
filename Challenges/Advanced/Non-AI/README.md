# Advanced Coding Challenge (Non-AI Assisted)

## Objective

Evaluate the ability to process structured data, apply multiple business rules, and produce a correct summary result using C# without AI-based assistance.

---

## Task Description

You are given a list of user activity records. Each record represents a single action performed by a user on a system.

Each activity contains:
- A **User ID**
- An **Action Type**
- A **Duration (in minutes)**

Your task is to calculate the **total active time per user**, applying the rules below.

---

## Rules

1. Only the following actions count as **active time**:
   - `Login`
   - `Upload`
   - `Download`

2. Any action with a duration of **0 or less** is ignored.

3. If a user performs **more than one action consecutively**, all valid actions count.

4. Output should include **every user that appears in the input**, even if their total active time is 0.

---

## Expected Output

A dictionary where:
- The **key** is the User ID
- The **value** is the total active time (in minutes)

---
