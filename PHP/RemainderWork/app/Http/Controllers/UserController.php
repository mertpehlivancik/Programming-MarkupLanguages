<?php

namespace App\Http\Controllers;

use App\User;
use Illuminate\Http\Request;

class UserController extends Controller
{

    public function index()
    {
        return User::with('company')->get();
    }

    public function create()
    {
        //
    }

    public function store(Request $request)
    {
        $this->validate($request,[
            'name'      =>  'required',
            'email'     =>  'required|email|unique:users',
            'password'  =>  'required'
        ],
            [
                'name.required'     =>  'İsim Alanı Zorunludur!',
                'email.required'    =>  'E-Posta Alanı Zorunludur',
                'email.email'       =>  'Lütfen Geçerli Bir E-Posta Adresi Yazın',
                'email.unique'      =>  'Bu E-Posta Adresi Başka Bir Kullanıcı Tarafından Kullanılmaktadır',
                'password.required' =>  'Şifre Alanı Zorunludur!'
            ]);
        $request->merge(['password' => bcrypt($request->password)]);
        User::create($request->all());
    }

    public function show($id)
    {
        //
    }

    public function edit($id)
    {
        //
    }

    public function update(Request $request, $id)
    {
        //
    }

    public function destroy($id)
    {
        //
    }
}
