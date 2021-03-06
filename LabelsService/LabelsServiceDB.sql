PGDMP                         y            LabelsServiceDB    13.2    13.2     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    16394    LabelsServiceDB    DATABASE     n   CREATE DATABASE "LabelsServiceDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
 !   DROP DATABASE "LabelsServiceDB";
                postgres    false            ?            1259    16397    ServiceResults    TABLE     ?   CREATE TABLE public."ServiceResults" (
    "ID" integer NOT NULL,
    "FileOld" bytea,
    "FileNew" bytea,
    "LabelsNames" character varying(1000)[],
    "LabelsValues" character varying(1000)[],
    "Images" bytea,
    "WorkingTime" interval
);
 $   DROP TABLE public."ServiceResults";
       public         heap    postgres    false            ?            1259    16395    ServiceResults_ID_seq    SEQUENCE     ?   ALTER TABLE public."ServiceResults" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."ServiceResults_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    201            ?            1259    16487    Users    TABLE     ?   CREATE TABLE public."Users" (
    "ID" integer NOT NULL,
    "Login" character varying(100),
    "Password" character varying(100)
);
    DROP TABLE public."Users";
       public         heap    postgres    false            ?            1259    16485    Users_ID_seq    SEQUENCE     ?   ALTER TABLE public."Users" ALTER COLUMN "ID" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Users_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    203            ?          0    16397    ServiceResults 
   TABLE DATA           ~   COPY public."ServiceResults" ("ID", "FileOld", "FileNew", "LabelsNames", "LabelsValues", "Images", "WorkingTime") FROM stdin;
    public          postgres    false    201   ?       ?          0    16487    Users 
   TABLE DATA           <   COPY public."Users" ("ID", "Login", "Password") FROM stdin;
    public          postgres    false    203          ?           0    0    ServiceResults_ID_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."ServiceResults_ID_seq"', 276, true);
          public          postgres    false    200            ?           0    0    Users_ID_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public."Users_ID_seq"', 28, true);
          public          postgres    false    202            +           2606    16404 "   ServiceResults ServiceResults_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."ServiceResults"
    ADD CONSTRAINT "ServiceResults_pkey" PRIMARY KEY ("ID");
 P   ALTER TABLE ONLY public."ServiceResults" DROP CONSTRAINT "ServiceResults_pkey";
       public            postgres    false    201            -           2606    16494    Users Users_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public."Users"
    ADD CONSTRAINT "Users_pkey" PRIMARY KEY ("ID");
 >   ALTER TABLE ONLY public."Users" DROP CONSTRAINT "Users_pkey";
       public            postgres    false    203            ?      x?????? ? ?      ?      x?????? ? ?     