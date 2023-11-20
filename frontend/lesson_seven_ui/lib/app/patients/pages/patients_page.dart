import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'package:lesson_seven_ui/app/patients/models/patient.dart';

final class PatientsPage extends StatefulWidget {
  const PatientsPage({super.key});

  @override
  State<PatientsPage> createState() => _PatientsPageState();
}

Future<List<Patient>> getPatients() async {
  // const url = 'http://10.0.2.2:8008/patients';
  const url = 'http://localhost:8008/patients';

  try {
    final response = await http.get(Uri.parse(url));

    final data = jsonDecode(response.body) as List;
    final patients = data.map((patient) => Patient.fromJson(patient)).toList();

    return patients;
  } catch (e) {
    debugPrint(e.toString());
    return [];
  }
}

class _PatientsPageState extends State<PatientsPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Patients'),
      ),
      body: Center(
          child: FutureBuilder(
        future: getPatients(),
        builder: (
          context,
          snapshot,
        ) {
          if (!snapshot.hasData) {
            return const Text('Loading...');
          }
          if (snapshot.hasError) {
            return const Text('Error Occured while fetching patients...');
          }
          return ListView.builder(
            itemCount: snapshot.data?.length,
            itemBuilder: (context, index) {
              final patient = snapshot.data?[index];
              return Column(
                children: [
                  Text(patient?.firstName ?? ''),
                  Text(patient?.lastName ?? ''),
                  Text(patient?.age.toString() ?? ''),
                ],
              );
            },
          );
        },
      )),
    );
  }
}
