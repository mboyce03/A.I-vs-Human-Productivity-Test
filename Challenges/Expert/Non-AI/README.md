# Expert Coding Challenge (Non-AI Assisted)

## Objective

Assess the ability to reason about system state over time, enforce complex rules, and produce a correct result under ambiguity using C# without AI-based assistance.

---

## Task Description

You are given a chronological list of system events representing user sessions.

Each event indicates when a user either **starts** or **ends** a session.

Your task is to calculate the **total valid session time per user**.

---

## Rules

1. A session starts with a `Start` event and ends with an `End` event.
2. Only **complete sessions** count toward total time.
3. If a user starts multiple sessions without ending the previous one:
   - Only the **most recent start** is valid.
4. If an `End` event appears without a matching `Start`, it is ignored.
5. Events are guaranteed to be in chronological order.
6. Output must include **all users who appear in the input**, even if their total time is 0.

---

## Expected Output

A dictionary where:
- The **key** is the User ID
- The **value** is the total valid session time (in minutes)

---

