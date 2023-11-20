final class Patient {
  final String firstName;
  final String lastName;
  final int age;

  const Patient({
    required this.firstName,
    required this.lastName,
    required this.age,
  });

  factory Patient.fromJson(Map<String, dynamic> json) => Patient(
        firstName: json['firstName'] ?? '',
        lastName: json['lastName'] ?? '',
        age: json['age'] ?? 0,
      );
}
