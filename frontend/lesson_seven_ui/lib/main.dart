import 'package:flutter/material.dart';
import 'package:lesson_seven_ui/app/patients/pages/patients_page.dart';

void main() => runApp(const App());

final class App extends StatelessWidget {
  const App({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(
          colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
          useMaterial3: true),
      home: const PatientsPage(),
    );
  }
}
